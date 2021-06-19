using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using  static Liver.Utils;

namespace Liver
{
    public partial class Editor : Form
    {
        private readonly Pic _pic;

        public Editor(Pic pic)
        {
            _pic = pic;
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Text = pic.Name;
            box.Image = pic.Image;
            Icon = HdIcon.ExtractFromPath(pic.Path);
            ResizeBox(1.0);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pic.Save(box.Image);
            MessageBox.Show($"Изображение {_pic.Name} успешно сохранено.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void åToolStripMenuItem_Click(object sender, EventArgs e)
        {
            box.Image = RotateImage(box.Image, -90);
        }

        private void æToolStripMenuItem_Click(object sender, EventArgs e)
        {
            box.Image = RotateImage(box.Image, 90);
        }

        void ResizeBox(double mult)
        {
            if (mult != 1.0)
            {
                box.Image = ResizeImage(box.Image, (int) (box.Image.Width * mult), (int) (box.Image.Height * mult));
            }
            stats.Text = $"{box.Image.Width}x{box.Image.Height}";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResizeBox(0.9);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ResizeBox(1.1);
        }

        private Point? _first;
        private Point? _second;

        void CutBox()
        {
            if (_first.HasValue && _second.HasValue)
            {
                var rec = new Rectangle();
                rec.X = Math.Min(_first.Value.X, _second.Value.X);
                rec.X = Math.Max(rec.X, 0);
                rec.Y = Math.Min(_first.Value.Y, _second.Value.Y);
                rec.Y = Math.Max(rec.Y, 0);
                rec.Width = Math.Abs(_first.Value.X - _second.Value.X);
                rec.Height = Math.Abs(_first.Value.Y - _second.Value.Y);
                rec.Width = Math.Min(rec.Width, box.Image.Width);
                rec.Height = Math.Min(rec.Height, box.Image.Height);
                box.Image = CropImage(box.Image, rec);
                _first = null;
                _second = null;
            }
        }

        private void box_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _first = e.Location;
                if (_second.HasValue)
                {
                    CutBox();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                _second = e.Location;
                if (_first.HasValue)
                {
                    CutBox();
                }
            }
        }
    }
}