using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proiect2
{
    static class  SupportedMediaFileExtensions
    {
        public static Dictionary<string, string> photos = new Dictionary<string, string>()
        {
            {"JPEG Image", ".jpg" },
            {"PNG Image", ".png" },
            {"GIF Image",".gif" }

        };

        public static IDictionary<string, string> videos = new Dictionary<string, string>()
        {
            {"mkv Video", ".mkv" },
            {"Windows Media Video", ".wmv"}
        };
    }
}
