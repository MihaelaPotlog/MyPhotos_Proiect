using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotosApi.Api;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;
using MyPhotosApi.Api.DTOs.RequestDtos;

namespace WCF_Service
{
    public class MyPhotosService : IMyPhotosService
    {
        private MyPhotosApi.Api.Interfaces.MyPhotosApi _myPhotosApi;
        public MyPhotosService()
        {
            _myPhotosApi = new MyPhotosApi.Api.Interfaces.MyPhotosApi();
        }
        public async Task Delete(int id)
        {
            await _myPhotosApi.MediaFileService.Delete(id);

        }

        public IList<FileDto> GetAll()
        {
            return _myPhotosApi.MediaFileService.GetAll();
        }

        public IList<string> GetDirectoryPhotosVideos(string directoryPath)
        {
            return _myPhotosApi.MediaFileService.GetDirectoryPhotosVideos(directoryPath);
        }

        public IList<FileDto> GetFilteredMediaFiles(FilterFilesDto dto)
        {
            return _myPhotosApi.MediaFileService.GetFilteredMediaFiles(dto);
        }

        public async Task<Response> LoadFile(CreateFileDto createFileDto)
        {
            return await _myPhotosApi.MediaFileService.LoadFile(createFileDto);
        }

        public async Task<Response> ModifyMediaFile(ModifyFileDto dto)
        {
            return await _myPhotosApi.MediaFileService.ModifyMediaFile(dto);
        }


        public async Task<Response> AddPropertyType(string name)
        {
            return await _myPhotosApi.PropertyTypeService.AddPropertyType(name);
        }

        public IList<PropertyTypeDto> GetAllPropertiesTypes()
        {
            return _myPhotosApi.PropertyTypeService.GetAllPropertiesTypes();
        }

        public IList<PropertyTypeValuesDto> GetAllPropertyTypesWithValues()
        {
            return _myPhotosApi.PropertyTypeService.GetAllPropertyTypesWithValues();
        }
    }
}
