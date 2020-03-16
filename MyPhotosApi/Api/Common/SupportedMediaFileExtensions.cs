using System.Collections.Generic;

namespace MyPhotosApi.Api.Constants
{
    public static class SupportedMediaFileExtensions
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
