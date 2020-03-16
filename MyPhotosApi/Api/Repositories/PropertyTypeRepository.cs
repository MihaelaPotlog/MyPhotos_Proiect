using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosApi.Api
{
    public class PropertyTypeRepository : IPropertyTypeRepository
    {
        private MyPhotosContext _myPhotosContext;

        internal PropertyTypeRepository(MyPhotosContext myPhotosContext)
        {
            _myPhotosContext = myPhotosContext;
        }

        public async Task<PropertyType> Get(int id)
        {
            return await _myPhotosContext.PropertyTypes.FindAsync(id);
        }
        public async Task<bool> AddPropertyType(string name)
        {
            PropertyType searchedPropertyType = _myPhotosContext.PropertyTypes.FirstOrDefault((propertyType) => propertyType.Name == name);
            
            if (searchedPropertyType == default(PropertyType))
            {
                PropertyType newPropertyType = new PropertyType() {Name = name};
                _myPhotosContext.PropertyTypes.Add(newPropertyType);
                await _myPhotosContext.SaveChangesAsync();
                return true;

            }
            else return false;

        }

        public IList<PropertyType> GetAll()
        {
            return _myPhotosContext.PropertyTypes.ToList();
        }

    }
}
