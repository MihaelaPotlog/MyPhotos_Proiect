using MyPhotosApi.Api;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;
using MyPhotosApi.Api.DTOs.RequestDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace WCF_Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MediaFileService : IMediaFileService
    {

        private MyPhotosApi.Api.Interfaces.MyPhotosApi _myPhotosApi;

        public MediaFileService()
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

        public Task<Response> LoadFile(CreateFileDto createFileDto)
        {
            return _myPhotosApi.MediaFileService.LoadFile(createFileDto);
        }

        public Task<Response> ModifyMediaFile(ModifyFileDto dto)
        {
            return _myPhotosApi.MediaFileService.ModifyMediaFile(dto);
        }
    }
}
