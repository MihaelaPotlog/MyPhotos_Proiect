using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPhotosApi.Api.Interfaces
{
    internal interface IPropertyValueRepository
    {
        Task<PropertyValue> Get(int id);

        Task Add(PropertyValue propertyValue);

        PropertyValue GetByValue(string value);

        PropertyValue GetByValueAndTypeId(string value, int propertyTypeId);
    }
}
