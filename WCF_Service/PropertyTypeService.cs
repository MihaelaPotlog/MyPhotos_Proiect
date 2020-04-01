using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class PropertyTypeService : IPropertyTypeService
    {
        private MyPhotosApi.Api.Interfaces.MyPhotosApi _myPhotosApi;

        public PropertyTypeService()
        {
            _myPhotosApi = new MyPhotosApi.Api.Interfaces.MyPhotosApi();
        }

        public Task<Response> AddPropertyType(string name)
        {
            return _myPhotosApi.PropertyTypeService.AddPropertyType(name);
        }

        public IList<PropertyTypeDto> GetAllPropertiesTypes()
        {
            return _myPhotosApi.PropertyTypeService.GetAllPropertiesTypes();
        }

        public IList<PropertyTypeValuesDto> GetAllPropertyTypesWithValues()
        {
            return _myPhotosApi.PropertyTypeService.GetAllPropertyTypesWithValues();
        }
    }
}
