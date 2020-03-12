using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosApi.Api
{
    public class PropertyTypeService : IPropertyTypeService
    {
        private MyPhotosContext _myPhotosContext;

        internal PropertyTypeService(MyPhotosContext myPhotosContext)
        {
            _myPhotosContext = myPhotosContext;
        }

        public bool AddCharacteristicType(string name)
        {
            PropertyType searchedPropertyType = _myPhotosContext.PropertyTypes.FirstOrDefault((propertyType) => propertyType.Name == name);
            
            if (searchedPropertyType == default(PropertyType))
            {
                PropertyType newPropertyType = new PropertyType() {Name = name};
                _myPhotosContext.PropertyTypes.Add(newPropertyType);
                return true;

            }
            else return false;

        }

        public IList<string> GetCharacteristicTypes()
        {
            return _myPhotosContext.PropertyTypes.Select(propertyType => propertyType.Name).ToList();
        }
    }
}
