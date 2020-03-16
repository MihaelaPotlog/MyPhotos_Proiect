using AutoMapper;
using MyPhotosApi.Api.DTOs.ResponseDtos;

namespace MyPhotosApi.Api.MappingDomainToDto
{
    public class PropertyDtoProfile:Profile
    {
        public PropertyDtoProfile()
        {
            CreateMap<PropertyValue, PropertyDto>()
                .ForMember(dest => dest.Id, opt =>
                    opt.MapFrom(src => src.PropertyTypeId))
                .ForMember(dest => dest.Type, opt =>
                    opt.MapFrom(src => src.PropertyType.Name));

        }
    }
}
