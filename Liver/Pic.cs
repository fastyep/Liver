using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Liver.Utils;

namespace Liver
{
    public class Pic
    {
        private Rectangle _bounds;
        private Image _image;
        private readonly Exception _exn;
        private readonly string _hash;
        private readonly FileInfo _file;
        public Pic(byte[] data)
        {
            var mem = new MemoryStream(data);
            try
            {
                _image = Image.FromStream(mem);
                _hash = GetMd5Hash(data);
            }
            catch (Exception ex)
            {
                _exn = ex;
            }
            finally
            {
                mem.Dispose();
            }
        }
        public Pic(FileInfo file) : this (File.ReadAllBytes(file.FullName))
        {
            _file = file;
        }

        public string Name
        {
            get => _file.Name;
            set
            {
                _file.MoveTo(_file.FullName.Replace(Name, value));
                _file.Refresh();
            }
        }

        public string Path => _file.FullName;

        public Exception Exn => new BadImageFormatException("Ошибка обработки изображения", _exn);

        public bool Ready => _image != null;

        public Image Image => _image ?? throw Exn;
        
        public ListViewItem Item { get; set; }

        public Image Icon
        {
            get
            {
                if (Image.Width > Image.Height)
                {
                    var icon = BitmapFromColor(Image.Width, Image.Width, Image.PixelFormat, Color.Black);
                    using (var ico = new BitmapEditor(icon, ImageLockMode.WriteOnly))
                        using (var img = new BitmapEditor(Image, ImageLockMode.ReadOnly))
                        {
                            var rgbValues = img.GetBytes();
                            var scan = ico.Data.Scan0;
                            for (int i = 0; i < Image.Height; i++)
                            {
                                var startIndex = img.Data.Stride * i;
                                var destination = scan + startIndex + img.Data.Stride * (icon.Height - Image.Height);
                                Marshal.Copy(rgbValues, startIndex, destination,img.Data.Stride);
                            }
                        }
                    icon.MakeTransparent(Color.Black);
                    return icon;
                }
                if (Image.Width < Image.Height)
                {
                    var icon = BitmapFromColor(Image.Height, Image.Height, Image.PixelFormat, Color.White);
                    using (var ico = new BitmapEditor(icon, ImageLockMode.WriteOnly))
                    using (var img = new BitmapEditor(Image, ImageLockMode.ReadOnly))
                    {
                        var rgbValues = img.GetBytes();
                        var scan = ico.Data.Scan0;
                        for (int i = 0; i < Image.Height; i++)
                        {
                            var startIndex = img.Data.Stride * i;
                            var shift = (ico.Data.Stride - img.Data.Stride) / 2 / 3 * 3;
                            var destination = scan + ico.Data.Stride * i + shift;
                            Marshal.Copy(rgbValues, startIndex, destination,img.Data.Stride);
                        }
                    }
                    icon.MakeTransparent();
                    return icon;
                }
                return Image;
            }
        }

        public string Hash => _hash ?? throw Exn;
        public Rectangle Bounds => _bounds;

        public bool InBounds(Point point) =>
            point.X > _bounds.X && point.X < _bounds.X + _bounds.Width &&
            point.Y > _bounds.Y && point.Y < _bounds.Y + _bounds.Height;

        public Rectangle FitBounds(Rectangle bounds)
        {
            var fit = bounds;
            var imgC = (double)Image.Width / Image.Height;
            var boundsC = (double)bounds.Width / bounds.Height;
            if (imgC < boundsC)
            {
                fit.Width = (int) (fit.Height * imgC);
                fit.X += (bounds.Width - fit.Width) / 2;
            }
            if (imgC > boundsC)
            {
                fit.Height = (int) (fit.Width / imgC);
                fit.Y += (bounds.Height - fit.Height) / 2;
            }
            _bounds = fit;
            return _bounds;
        }

        public bool Delete()
        {
            if (_file == null) return false;
            _file.Delete();
            _file.Refresh();
            return !_file.Exists;
        }

        public void Save(Image img)
        {
            _image = img;
            _image.Save(_file.FullName);
        }
    }
}