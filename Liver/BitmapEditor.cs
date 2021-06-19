using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Liver
{
    
    public class BitmapEditor : IDisposable
    {
        private readonly Bitmap _bitmap;
        private readonly BitmapData _bitmapData;

        public BitmapEditor(Bitmap bitmap, ImageLockMode mode)
        {
            _bitmap = bitmap;
            var rect = new Rectangle(0, 0, _bitmap.Width, _bitmap.Height);
            _bitmapData = _bitmap.LockBits(rect, mode, _bitmap.PixelFormat);
        }
        public BitmapEditor(Image img, ImageLockMode mode) : this((Bitmap)img, mode) { }

        public BitmapData Data => _bitmapData;
        public Bitmap Image => _bitmap;

        public byte[] GetBytes()
        {
            int bytes  = Math.Abs(_bitmapData.Stride) * _bitmap.Height;
            byte[] rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(_bitmapData.Scan0, rgbValues, 0, bytes);
            return rgbValues;
        }

        public void SetBytes(byte[] rgbValues)
        {
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, _bitmapData.Scan0, rgbValues.Length);
        }

        public void Dispose()
        {
            _bitmap.UnlockBits(_bitmapData);
        }
    }
}