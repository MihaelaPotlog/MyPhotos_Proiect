using AutoMapper;
using MyPhotosApi.Api.DTOs;

namespace MyPhotosApi.Api.MappingDomainToDto
{
    class PropertyTypeToPropertyDtoProfile:Profile
    {
        public PropertyTypeToPropertyDtoProfile()
        {
            CreateMap<PropertyType, PropertyTypeDto>();
        }
    }
}
