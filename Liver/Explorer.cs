using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liver
{
    public partial class Explorer : Form, ISettings
    {
        private readonly string _media;
        private readonly string _text;
        private Pic[] _collagePics = new Pic[0];
        private readonly Control[] _frame = Enumerable.Range(0, 4).Select(_ => new Panel { Visible = false}).ToArray();
        private Action<Point> _mouseMove;
        private int _perPage = 9;
        private Color _collageColor = Color.Pink;
        private Pic _collageSelected;

        public Explorer()
        {
            InitializeComponent();
            collagePanel.Controls.AddRange(_frame);
            Icon = HdIcon.ExtractFromPath(@"C:\Windows");
            _text = Text;
            _media = ".jpg.png.jpeg.gif.bmp.";
            filesView.LargeImageList = new ImageList();
            filesView.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
            filesView.LargeImageList.ImageSize = new Size(64, 64);
            filesView.Columns.Add(new ColumnHeader { Text = "Имя", Width = 320});
            filesView.Columns.Add(new ColumnHeader { Text = "Размер", Width = 80});
            filesView.Columns.Add(new ColumnHeader { Text = "Дата снимка", Width = 120});
            filesView.View = View.LargeIcon;
            OpenDir(new DirectoryInfo($@"C:\Users\{Environment.UserName}\Pictures"));
        }

        void SetText(string text) => Text = string.IsNullOrEmpty(text) ? _text : text + " - " + _text;

        void OpenExplorer()
        {
            _collageSelected = null;
            filesView.Show();
            collagePanel.Hide();
        }

        void OpenDrives()
        {
            OpenExplorer();
            var drives = DriveInfo.GetDrives()
                .Where(d => d.IsReady)
                .Select(d => new ListViewItem
                {
                    Text = $"{d.VolumeLabel} ({d.Name})", 
                    ImageKey = filesView.LargeImageList.AddKey(d.Name, d.Name), 
                    Tag = d.RootDirectory
                })
                .ToArray();
            filesView.Items.Clear();
            filesView.Items.AddRange(drives);
            SetText(null);
        }

        void OpenDir(DirectoryInfo dir)
        {
            OpenExplorer();
            filesView.LargeImageList.Images.Clear();
            var folders = dir.EnumerateDirectories()
                .Select(d => new ListViewItem
                {
                    Text = d.Name, 
                    ImageKey = filesView.LargeImageList.AddKey(d.Name, d.FullName), 
                    Tag = d
                })
                .ToArray();
            var files = dir.EnumerateFiles()
                .Where(f => _media.Contains(f.Extension + "."))
                .Select(f =>
                {
                    var img = new Pic(f);
                    if (img.Ready)
                    {
                        filesView.LargeImageList.Images.Add(img.Name, img.Icon);
                    }
                    else
                    {
                        filesView.LargeImageList.AddKey(f.Name, f.FullName);
                    }

                    var size = img.Ready ? $"{img.Image.Width}x{img.Image.Height}" : "";
                    var item = new ListViewItem { Text = f.Name, SubItems =
                    {
                        new ListViewItem.ListViewSubItem { Text = size },
                        new ListViewItem.ListViewSubItem { Text = f.CreationTime.ToLongDateString() }
                    }, ImageKey = img.Name, Tag = img };
                    img.Item = item;
                    return item;
                })
                .ToArray();
            filesView.Items.Clear();
            if (dir.Parent != null)
            {
                filesView.Items.Add(new ListViewItem
                {
                    Text = "..", 
                    ImageKey = filesView.LargeImageList.AddKey("..", dir.Parent.FullName), 
                    Tag = dir.Parent
                });
            }
            filesView.Items.AddRange(folders);
            filesView.Items.AddRange(files);
            _mouseMove = point =>
            {
                MoveFrame(CollagePics.Take(PerPage).SingleOrDefault(a => a.InBounds(point)));
            };
            SetText(dir.FullName);
        }

        private void iconsMainMenu_Click(object sender, EventArgs e)
        {
            OpenExplorer();
            filesView.View = View.LargeIcon;
        }

        private void tableMainMenu_Click(object sender, EventArgs e)
        {
            OpenExplorer();
            filesView.View = View.Details;
        }

        private void filesView_DoubleClick(object sender, EventArgs e)
        {
            var tag = filesView.SelectedItems[0].Tag;
            if (tag == null)
            {
                OpenDrives();
                return;
            }
            if (tag is DirectoryInfo)
            {
                OpenDir(tag as DirectoryInfo);
                return;
            }
            var pcs = SelectedPics;
            if (pcs.Length > 0) Viewer.Open(pcs);
        }

        private void rootMainMenu_Click(object sender, EventArgs e)
        {
            var tag = filesView.Items[0].Tag;
            if (tag is DirectoryInfo)
            {
                OpenDir((tag as DirectoryInfo).Root);
            }
        }

        private void drivesMainMenu_Click(object sender, EventArgs e)
        {
            OpenDrives();
        }

        private void collageMainMenu_Click(object sender, EventArgs e)
        {
            _collagePics = filesView.SelectedItems
                .Cast<ListViewItem>()
                .Select(a => a.Tag as Pic)
                .Where(a => a?.Ready == true)
                .ToArray();
            filesView.Hide();
            collagePanel.Show();
        }

        public int PerPage
        {
            get => _perPage;
            set
            {
                _perPage = value;
                collagePanel.Invalidate();
                MoveFrame(null);
            }
        }

        public int FrameSize { get; set; } = 2;

        public Color CollageColor
        {
            get => _collageColor;
            set
            {
                _collageColor = value;
                collagePanel.Invalidate();
            }
        }

        public Color FrameColor
        {
            get => collagePanel.BackColor;
            set => collagePanel.BackColor = value;
        }

        private IEnumerable<Pic> CollagePics =>
            _collagePics.Any() ? _collagePics : filesView.Items.Cast<ListViewItem>()
                .Select(a => a.Tag as Pic).Where(a => a?.Ready == true);

        private Pic[] SelectedPics =>
            _collageSelected != null
                ? new[] {_collageSelected}
                : filesView.SelectedItems.Cast<ListViewItem>()
                    .Select(a => a.Tag as Pic).Where(a => a != null).ToArray();

        private void collagePanel_Paint(object sender, PaintEventArgs e)
        {
            var plane = sender as Control;
            if (plane?.Visible != true) return;
            _panelBmp = new Bitmap(collagePanel.Width, collagePanel.Height);
            var g = Graphics.FromImage(_panelBmp);
            g.Clear(CollageColor);
            int i = 0;
            var line = (int)Math.Sqrt(PerPage);
            if (line * line < PerPage) line++;
            var xi = plane.Width / line - FrameSize * line;
            var yi = plane.Height / line - FrameSize * line;
            foreach (var img in CollagePics.Take(PerPage))
            {
                var doubleFrame = FrameSize * 2;
                var bounds = new Rectangle(i%line*(xi+doubleFrame)+FrameSize, i/line*(yi+doubleFrame)+FrameSize, xi, yi);
                var rect = img.FitBounds(bounds);
                g.DrawImage(img.Image, rect);
                i++;
            }
            e.Graphics.DrawImage(_panelBmp, Point.Empty);
        }

        private Bitmap _panelBmp;

        void MoveFrame(Pic to)
        {
            if (to != null)
            {
                for (int i = 0; i < 4; i++)
                {
                    var panel = _frame[i];
                    panel.BackColor = FrameColor;
                    panel.Location = new Point(to.Bounds.X - FrameSize, to.Bounds.Y - FrameSize);
                    if (i == 2) panel.Top += to.Bounds.Height;
                    if (i == 3) panel.Left += to.Bounds.Width;
                    int x2 = FrameSize * 2;
                    panel.Size = i % 2 == 0
                        ? new Size(to.Bounds.Width + x2, x2)
                        : new Size(x2, to.Bounds.Height + x2);
                }
            }
            foreach (var panel in _frame)
            {
                panel.Visible = to != null;
            }
            _collageSelected = to;
        }

        private void collagePanel_SizeChanged(object sender, EventArgs e)
        {
            collagePanel.Invalidate();
        }

        private void collagePanel_MouseMove(object sender, MouseEventArgs e)
        {
            _mouseMove?.Invoke(e.Location);
        }

        private void settingsMainMenu_Click(object sender, EventArgs e)
        {
            new Settings(this).ShowDialog();
        }

        private void commentsMenuItem_Click(object sender, EventArgs e)
        {
            var pics = SelectedPics;
            if (pics.Length != 1) return;
            var pic = pics[0];
            if (pic.Ready)
            {
                new Comments(pic).ShowDialog();
            }
            else
            {
                MessageBox.Show(pic.Exn.InnerException.Message, "Ошибка изображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void lentaMenuItem_Click(object sender, EventArgs e)
        {
            new Lenta(SelectedPics).ShowDialog();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var pics = SelectedPics;
            var text = $"Удалить {pics.Length} файлов?";
            if (pics.Length < 1) return;
            if (pics.Length == 1) text = $"Удалить {pics[0].Name}?";
            if (MessageBox.Show(text, "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var file in pics)
                {
                    if (file.Delete())
                    {
                        filesView.Items.Remove(file.Item);   
                    }
                }
                collagePanel.Invalidate();
            }
        }

        private void переименоватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var pics = SelectedPics;
            if (pics.Length != 1) return;
            var pic = pics[0];
            var result = Prompt.ShowDialog("Введите название файла:", "Переименовать", pic.Name);
            if(string.IsNullOrEmpty(result)) return;
            pic.Item.Text = result;
            filesView.Refresh();
            pic.Name = result;
        }

        private void filesView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && filesView.FocusedItem.Bounds.Contains(e.Location))
            {
                filesContext.Show(Cursor.Position);
            } 
        }

        private void collagePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _collageSelected != null)
            {
                Viewer.Open(SelectedPics);
            }
            else if (e.Button == MouseButtons.Right)
            {
                (_collageSelected == null ? collageContext : filesContext).Show(Cursor.Position);
            } 
        }

        private void сохранитьКакToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var d = new SaveFileDialog
            {
                FileName = "Коллажик.jpg"
            };
            if (d.ShowDialog() == DialogResult.OK)
            {
                _panelBmp.Save(d.FileName);
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pic = SelectedPics.FirstOrDefault(a => a.Ready);
            if (pic != null)
            {
                new Editor(pic).ShowDialog();
            }
        }
    }
}