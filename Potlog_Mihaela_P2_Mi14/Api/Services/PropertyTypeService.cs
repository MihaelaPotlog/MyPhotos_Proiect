using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;
using MyPhotosApi.Api.DTOs.RequestDtos;
using MyPhotosApi.Api.Interfaces;
using MyPhotosApi.Api.Repositories;

namespace MyPhotosApi.Services
{
    public class PropertyTypeService:IPropertyTypeService
    {
        private MyPhotosWrapper _myPhotosWrapper;
        private IMapper _mapper;

        public PropertyTypeService(MyPhotosWrapper myPhotosWrapper, IMapper mapper)
        {
            _myPhotosWrapper = myPhotosWrapper;
            _mapper = mapper;
        }

        public IList<PropertyTypeDto> GetAllPropertiesTypes()
        {
            return _mapper.Map<IList<PropertyTypeDto>>(_myPhotosWrapper.PropertyTypes.GetAll());
        }

        public IList<PropertyTypeValuesDto> GetAllPropertyTypesWithValues()
        {
            return _mapper.Map<IList<PropertyTypeValuesDto>>(_myPhotosWrapper.PropertyTypes.GetAll());
        }

        public async Task<Response> AddPropertyType(string name)
        {
            var result = await _myPhotosWrapper.PropertyTypes.AddPropertyType(name);
            if(result)
                return new Response(true, "Succeeded");
            else
            {
                return new Response(false, ErrorMessages.PropertyTypeIsAlreadyAdded);
            }
        }
        
    }
}
