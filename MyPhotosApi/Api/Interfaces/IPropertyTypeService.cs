using System.Collections.Generic;
using System.Threading.Tasks;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;

namespace MyPhotosApi.Api.Interfaces
{
    public interface IPropertyTypeService
    {
        IList<PropertyTypeDto> GetAllPropertiesTypes();
        IList<PropertyTypeValuesDto> GetAllPropertyTypesWithValues();
        Task<Response> AddPropertyType(string name);
    }
}
