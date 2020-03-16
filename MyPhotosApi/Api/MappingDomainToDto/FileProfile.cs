using AutoMapper;
using MyPhotosApi.Api.DTOs;

namespace MyPhotosApi.Api.MappingDomainToDto
{
    public class FileProfile : Profile
    {
        public FileProfile()
        {
            CreateMap<MediaFile, FileDto>()
                .ForMember(dest => dest.Properties, opt =>
                    opt.MapFrom(src => src.PropertyValues));
        }
    }
}
