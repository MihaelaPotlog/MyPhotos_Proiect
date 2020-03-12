using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotosApi.Api.Constants;

namespace MyPhotosApi.Api
{
    public class FileService : IFileService
    {
        private MyPhotosContext _myPhotosContext;
        private List<string> PhotoExtensions = new List<string>()
        {
            ".jpg"
        };
        private List<string> _videoExtensions = new List<string>()
        {
            ".mkv"
        };

        internal FileService(MyPhotosContext myPhotosContext)
        {
            _myPhotosContext = myPhotosContext;
        }

        public async Task<string> LoadFile(FileDto fileDto)
        {
            File searchedFile = _myPhotosContext.Files.FirstOrDefault(file => file.Path == fileDto.Path);
            // .verifica daca exista 
            if (searchedFile == default(File) && System.IO.File.Exists(fileDto.Path))
            {
                string extension = Path.GetExtension(fileDto.Path).ToLower();
                bool fileType;

                if (PhotoExtensions.Contains(extension))
                    fileType = FileType.Photo;
                else if (_videoExtensions.Contains(extension))
                    fileType = FileType.Video;
                else 
                    return "nu este";

                File createdFile = new File()
                {
                    Path = fileDto.Path,
                    Name = Path.GetFileNameWithoutExtension(fileDto.Path),
                    Erased = false,
                    Type = fileType,
                    Date = System.IO.File.GetCreationTime(fileDto.Path)
                };
                foreach (var propertyValueId in fileDto.PropertyValues)
                {
                    PropertyValue propertyValue = await _myPhotosContext.PropertyValues.FindAsync(propertyValueId);
                    createdFile.PropertyValues.Add(propertyValue);
                }

                _myPhotosContext.Files.Add(createdFile);
                await _myPhotosContext.SaveChangesAsync();
                return "yes";
            }

            return "no";

        }

        public async Task<string> LoadDirectorySubFiles(IList<FileDto> FILE)
        {
            return "somn";

        }
    }
}
