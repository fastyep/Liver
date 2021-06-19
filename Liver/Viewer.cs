using System;
using System.Linq;
using System.Windows.Forms;

namespace Liver
{
    public partial class Viewer : Form
    {
        private readonly PictureBox[] _frames;

        public static void Open(Pic[] pics)
        {
            var error = pics.FirstOrDefault(a => !a.Ready);
            if (error != null)
            {
                MessageBox.Show(error.Exn.InnerException.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var arr = pics.Take(2).ToArray();
                if (arr.Length > 0)
                {
                    new Viewer(arr).Show();
                }
            }
        }
        
        private Viewer(Pic[] pics)
        {
            InitializeComponent();
            _frames = pics.Select((pic, i) =>
            {
                var frame = i == 0 ? pictureBox1 : pictureBox2;
                frame.Tag = pic;
                frame.Image = pic.Image;
                frame.Visible = true;
                return frame;

            }).ToArray();
            Text = string.Join(" & ", pics.Select(a => a.Name));
            WindowState = FormWindowState.Maximized;
            Icon = HdIcon.ExtractFromPath($@"C:\Users\{Environment.UserName}\Pictures");
        }

        private void Viewer_Resize(object sender, EventArgs e)
        {
            foreach (var frame in _frames)
            {
                frame.Width = Width / _frames.Length;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var ses = (TrackBar) sender;
            zoomLabel.Text = ses.Value + "%";
            foreach (var frame in _frames)
            {
                var pic = (Pic) frame.Tag;
                var mult = (double)ses.Value / 100;
                frame.Image = Utils.ResizeImage(pic.Image, (int)(pic.Image.Width * mult), (int)(pic.Image.Height * mult));
            }
        }
    }
}