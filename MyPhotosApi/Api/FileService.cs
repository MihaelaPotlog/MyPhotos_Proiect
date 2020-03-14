using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.Interfaces;

namespace MyPhotosApi.Api
{
    public class FileService : IFileService
    {
        private MyPhotosContext _myPhotosContext;
        private IPropertyValueService _propertyValueService;
       

        internal FileService(MyPhotosContext myPhotosContext)
        {
            _myPhotosContext = myPhotosContext;
            _propertyValueService = new PropertyValueService(_myPhotosContext);
        }

        public async Task<string> LoadFile(FileDto fileDto)
        {
            File searchedFile = _myPhotosContext.Files.FirstOrDefault(file => file.Path == fileDto.Path);

            if (searchedFile == default(File) && System.IO.File.Exists(fileDto.Path))
            {
                string extension = Path.GetExtension(fileDto.Path);

                if (extension == null)
                    return ErrorMessages.IsNotMediaFile;
                else
                    extension = extension.ToLower();
                
                bool fileType;

                if (MediaFileExtensions.photos.Contains(extension))
                    fileType = FileType.Photo;

                else 
                    if (MediaFileExtensions.videos.Contains(extension))
                    fileType = FileType.Video;
                else
                    return ErrorMessages.IsNotMediaFile;

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

                foreach (var propertyTypeValues in fileDto.NewPropertyValues)
                {
                    await _propertyValueService.AddManyPropertyValues(propertyTypeValues.Key, propertyTypeValues.Value);
                }

                _myPhotosContext.Files.Add(createdFile);
                await _myPhotosContext.SaveChangesAsync();
                return "yes";
            }

            return "no";

        }

        public IList<string> GetDirectoryPhotosVideos(string directoryPath)
        {
            IList<string> mediaFiles = new List<string>();

            if (Directory.Exists(directoryPath))
            {
                IList<string> filenames = Directory.EnumerateFiles(directoryPath, "*.*", SearchOption.AllDirectories)
                    .ToList();

                foreach (var filename in filenames)
                {
                    string extension = Path.GetExtension(filename);

                    if (MediaFileExtensions.photos.Contains(extension) || MediaFileExtensions.videos.Contains(extension))
                        mediaFiles.Add(filename);
                }

            }

            return mediaFiles;

        }
    }
}
