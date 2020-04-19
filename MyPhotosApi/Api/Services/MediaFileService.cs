using System;
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
                return new Response(false, ErrorMessages.FileDoesNotExist);

            if (searchedFile != default(MediaFile))
            {
                return new Response(false, ErrorMessages.FileIsAlreadyAdded);
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


        public async Task<Response> ModifyMediaFile(ModifyFileDto dto)
        {
            MediaFile modifiedMediaFile = await _myPhotosWrapper.MediaFiles.Get(dto.FileId);
            if (modifiedMediaFile == null)
                return new Response(false, ErrorMessages.FileDoesNotExist);

            foreach (var addedPropertyInfo in dto.AddedPropertiesInfo)
            {
                var addedProperty =
                    _myPhotosWrapper.PropertyValues.GetByValueAndTypeId(addedPropertyInfo.Value, addedPropertyInfo.Key);
                if (addedProperty != default(PropertyValue))
                {
                    modifiedMediaFile.PropertyValues.Add(addedProperty);
                    await _myPhotosWrapper.MediaFiles.CommitAsync();
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
                    await _myPhotosWrapper.MediaFiles.CommitAsync();

                }
            }

            foreach (var deletedPropertyInfo in dto.DeletedPropertiesInfo)
            {
                var toDeletePropertyValue = _myPhotosWrapper.PropertyValues.GetByValueAndTypeId(deletedPropertyInfo.Value, deletedPropertyInfo.Key);
                Console.WriteLine($"{toDeletePropertyValue.Value}, ID={toDeletePropertyValue.PropertyTypeId}");
                if (toDeletePropertyValue != default(PropertyValue))
                {
                    Console.WriteLine("erased");
                    Console.WriteLine(modifiedMediaFile.PropertyValues.Remove(toDeletePropertyValue));
                    await _myPhotosWrapper.MediaFiles.CommitAsync();
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

        public async Task Delete(int id)
        {
            await _myPhotosWrapper.MediaFiles.Delete(id);
        }

    }
}
