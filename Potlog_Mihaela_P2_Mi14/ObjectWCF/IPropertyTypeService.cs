using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MyPhotosApi.Api.Constants;
using MyPhotosApi.Api.DTOs;

namespace WCF_Service
{
    [ServiceContract]
    public interface IPropertyTypeService
    {
        [OperationContract]
        IList<PropertyTypeDto> GetAllPropertiesTypes();
        [OperationContract]
        IList<PropertyTypeValuesDto> GetAllPropertyTypesWithValues();
        [OperationContract]
        Task<Response> AddPropertyType(string name);
    }
}
