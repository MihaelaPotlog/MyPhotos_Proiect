using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;
using MyPhotosApi.Api.DTOs.RequestDtos;

namespace MyPhotosApi.Api
{
    public interface IMediaFileService
    {

        IList<FileDto> GetAll();
        Task<Response> LoadFile(CreateFileDto createFileDto);
        Task<Response> ModifyMediaFile(ModifyFileDto dto);
        IList<string> GetDirectoryPhotosVideos(string directoryPath);
        IList<FileDto> GetFilteredMediaFiles(FilterFilesDto dto);
        Task Delete(int id);

    }
}
