using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosApi.Api.Constants
{
    static class MediaFileExtensions
    {
        internal static List<string> photos = new List<string>()
        {
            ".jpg"
        };
        internal static List<string> videos = new List<string>()
        {
            ".mkv"
        };
    }
}
