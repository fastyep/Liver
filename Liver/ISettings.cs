using System.Drawing;

namespace Liver
{
    public interface ISettings
    {
        int PerPage { get; set; }
        Color CollageColor { get; set; }
        Color FrameColor { get; set; }
    }
}