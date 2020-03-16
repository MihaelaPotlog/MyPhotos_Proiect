using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPhotosApi.Api.Interfaces;

namespace MyPhotosApi.Api
{
    class PropertyValueRepository : IPropertyValueRepository
    {
        private MyPhotosContext _myPhotosContext;

        internal PropertyValueRepository(MyPhotosContext myPhotosContext)
        {
            _myPhotosContext = myPhotosContext;
        }


        public async Task<PropertyValue> Get(int id)
        {
            return await _myPhotosContext.PropertyValues.FindAsync(id);
        }
        public async Task Add(PropertyValue propertyValue)
        {
             _myPhotosContext.PropertyValues.Add(propertyValue);
             await _myPhotosContext.SaveChangesAsync();
        }

        public PropertyValue GetByValue(string value)
        {
            return _myPhotosContext.PropertyValues.FirstOrDefault(propertyValue => propertyValue.Value == value);

        }
        public PropertyValue GetByValueAndTypeId(string value, int propertyTypeId)
        {
            return _myPhotosContext.PropertyValues.FirstOrDefault(propertyValue => propertyValue.Value == value
                                                                                   && propertyValue.PropertyTypeId == propertyTypeId);

        }
    }
}
