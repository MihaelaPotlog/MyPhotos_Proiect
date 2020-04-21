using System.Linq;
using AutoMapper;
using MyPhotosApi.Api.DTOs;

namespace MyPhotosApi.Api.MappingDomainToDto
{
    public class PropertyTypeValuesProfile : Profile
    {
        public PropertyTypeValuesProfile()
        {
            CreateMap<PropertyType, PropertyTypeValuesDto>()
                .ForMember(dto => dto.Values, opt =>
                    opt.MapFrom(src => src.PropertyValues.Select(propertyValue => propertyValue.Value)));
        }
    }
}
