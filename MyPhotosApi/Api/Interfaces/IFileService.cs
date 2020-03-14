using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosApi.Api
{
    public interface IFileService
    {
        Task<string> LoadFile(FileDto fileDto);
        IList<string> GetDirectoryPhotosVideos(string directoryPath);
    }
}
