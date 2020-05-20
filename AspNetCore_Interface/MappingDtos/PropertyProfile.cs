using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_Interface.Models;
using AutoMapper;
using ServiceReferenceMyPhotos;

namespace AspNetCore_Interface.MappingDtos
{
    public class PropertyProfile : Profile
    {
        public PropertyProfile()
        {
            CreateMap<PropertyDto, Property>();
        }
    }
}
