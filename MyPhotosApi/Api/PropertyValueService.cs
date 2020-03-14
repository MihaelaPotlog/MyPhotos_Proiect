using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotosApi.Api.Interfaces;

namespace MyPhotosApi.Api
{
    class PropertyValueService : IPropertyValueService
    {
        private MyPhotosContext _myPhotosContext;

        internal PropertyValueService(MyPhotosContext myPhotosContext)
        {
            _myPhotosContext = myPhotosContext;
        }

       

        public async Task AddOnePropertyValue(int propertyTypeId, string value)
        {
            PropertyValue newPropertyValue = new PropertyValue()
            {
                PropertyTypeId = propertyTypeId,
                Value = value
            };

            _myPhotosContext.PropertyValues.Add(newPropertyValue);
            await _myPhotosContext.SaveChangesAsync();
        }
        public async Task AddManyPropertyValues(int propertyTypeId, IList<string> propertyValues)
        {
            foreach (var propertyValue in propertyValues)
            {
                PropertyValue newPropertyValue = new PropertyValue()
                {
                    PropertyTypeId = propertyTypeId,
                    Value = propertyValue
                };
                _myPhotosContext.PropertyValues.Add(newPropertyValue);
            }
            await _myPhotosContext.SaveChangesAsync();
        }
    }
}
