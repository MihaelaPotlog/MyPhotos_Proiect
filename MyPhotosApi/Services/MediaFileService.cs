using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;
using MyPhotosApi.Api.DTOs.RequestDtos;
using MyPhotosApi.Api.Repositories;

namespace MyPhotosApi.Api
{
    public class MediaFileService : IMediaFileService
    {
        private MyPhotosWrapper _myPhotosWrapper;
        private IMapper _mapper;


        public MediaFileService(MyPhotosWrapper myPhotosWrapper, IMapper mapper)
        {
            this._myPhotosWrapper = myPhotosWrapper;
            this._mapper = mapper;
        }

        public async Task<Response> LoadFile(CreateFileDto createFileDto)
        {
            MediaFile searchedFile = _myPhotosWrapper.MediaFiles.GetByPath(createFileDto.Path);

            if (System.IO.File.Exists(createFileDto.Path) == false)
                return new Response(false, "The file does not exist");

            if (searchedFile != default(MediaFile))
            {
                return new Response(false, "The file is already added");
            }

            string extension = Path.GetExtension(createFileDto.Path);

            if (extension == null)
                return new Response(false, ErrorMessages.IsNotMediaFile);
            extension = extension.ToLower();

            bool fileType;

            if (SupportedMediaFileExtensions.photos.Values.Contains(extension))
                fileType = FileType.Photo;

            else
                if (SupportedMediaFileExtensions.videos.Values.Contains(extension))
                fileType = FileType.Video;
            else
                return new Response(false, ErrorMessages.IsNotMediaFile);

            MediaFile createdFile = new MediaFile()
            {
                Path = createFileDto.Path,
                Name = Path.GetFileNameWithoutExtension(createFileDto.Path),
                Erased = false,
                Type = fileType,
                Date = System.IO.File.GetCreationTime(createFileDto.Path)
            };

            foreach (var propertyTypeValues in createFileDto.Properties)
            {
                var propertyType = await _myPhotosWrapper.PropertyTypes.Get(propertyTypeValues.Key);

                foreach (var propertyValue in propertyTypeValues.Value)
                {
                    var searchedPropertyValue = _myPhotosWrapper.PropertyValues.GetByValueAndTypeId(propertyValue, propertyType.Id);

                    if (searchedPropertyValue != default(PropertyValue))
                        createdFile.PropertyValues.Add(searchedPropertyValue);
                    else
                    {
                        var newPropertyValue = new PropertyValue()
                        {
                            Value = propertyValue,
                            PropertyType = propertyType
                        };

                        await _myPhotosWrapper.PropertyValues.Add(newPropertyValue);
                        createdFile.PropertyValues.Add(newPropertyValue);
                    }
                }
            }


            await _myPhotosWrapper.MediaFiles.Add(createdFile);
            return new Response(true, "Succeeded");
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

                    if (SupportedMediaFileExtensions.photos.Values.Contains(extension) || SupportedMediaFileExtensions.videos.Values.Contains(extension))
                        mediaFiles.Add(filename);
                }

            }

            return mediaFiles;

        }

        public async Task<Response> AddPropertyValueToMediaFile(int mediaFileId, int propertyValueId)
        {
            MediaFile searchedMediaFile = await _myPhotosWrapper.MediaFiles.Get(mediaFileId);
            if (searchedMediaFile == null)
                return new Response(false, "The file does not exist");

            PropertyValue searchedPropertyValue = await _myPhotosWrapper.PropertyValues.Get(propertyValueId);
            if (searchedPropertyValue == null)
                return new Response(false, "The property value does not exist");

            searchedMediaFile.PropertyValues.Add(searchedPropertyValue);
            await _myPhotosWrapper.MediaFiles.Update();

            return new Response(true, "Succeeded");

        }

        public async Task<Response> ModifyMediaFile(ModifyFileDto dto)
        {
            MediaFile modifiedMediaFile = await _myPhotosWrapper.MediaFiles.Get(dto.FileId);
            if (modifiedMediaFile == null)
                return new Response(false, "The file does not exist");

            foreach (var addedPropertyInfo in dto.AddedPropertiesInfo)
            {
                var addedProperty =
                    _myPhotosWrapper.PropertyValues.GetByValueAndTypeId(addedPropertyInfo.Value, addedPropertyInfo.Key);
                if (addedProperty != default(PropertyValue))
                {
                    modifiedMediaFile.PropertyValues.Add(addedProperty);
                    await _myPhotosWrapper.MediaFiles.Update();
                }
                else
                {
                    var propertyType = await _myPhotosWrapper.PropertyTypes.Get(addedPropertyInfo.Key);
                    var newPropertyValue = new PropertyValue()
                    {
                        Value = addedPropertyInfo.Value,
                        PropertyType = propertyType
                    };

                    await _myPhotosWrapper.PropertyValues.Add(newPropertyValue);
                    modifiedMediaFile.PropertyValues.Add(newPropertyValue);
                    _myPhotosWrapper.MediaFiles.Update();

                }
            }

            foreach (var deletedPropertyInfo in dto.DeletedPropertiesInfo)
            {
                var toDeletePropertyValue = _myPhotosWrapper.PropertyValues.GetByValueAndTypeId(deletedPropertyInfo.Value, deletedPropertyInfo.Key);
                if (toDeletePropertyValue != default(PropertyValue))
                {
                    modifiedMediaFile.PropertyValues.Remove(toDeletePropertyValue);
                    await _myPhotosWrapper.MediaFiles.Update();
                }
            }
            return new Response(true, "Succeded");
        }

        public IList<FileDto> GetFilteredMediaFiles(FilterFilesDto dto)
        {
            var filteredFiles = _myPhotosWrapper.MediaFiles.FindManyByProperty(dto.PropertyTypeId, dto.PropertyValue);
            return _mapper.Map<IList<FileDto>>(filteredFiles);
        }

        public IList<FileDto> GetAll()
        {
            return _mapper.Map<IList<FileDto>>(_myPhotosWrapper.MediaFiles.GetAll());
        }

    }
}
