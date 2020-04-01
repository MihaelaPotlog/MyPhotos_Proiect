using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyPhotosApi.Api;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;
using MyPhotosApi.Api.DTOs.RequestDtos;

namespace WCF_Service
{
    [ServiceContract]
    public interface IMediaFileService
    {
        [OperationContract]
        IList<FileDto> GetAll();
        [OperationContract]
        Task<Response> LoadFile(CreateFileDto createFileDto);
        [OperationContract]
        Task<Response> ModifyMediaFile(ModifyFileDto dto);
        [OperationContract]
        IList<string> GetDirectoryPhotosVideos(string directoryPath);
        [OperationContract]
        IList<FileDto> GetFilteredMediaFiles(FilterFilesDto dto);
        [OperationContract]
        Task Delete(int id);
    }
}
