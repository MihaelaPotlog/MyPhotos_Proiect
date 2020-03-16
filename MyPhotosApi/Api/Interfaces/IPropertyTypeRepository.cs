using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPhotosApi.Api
{
    public interface IPropertyTypeRepository
    {
        Task<bool> AddPropertyType(string name);
        Task<PropertyType> Get(int id);
        IList<PropertyType> GetAll();
        IList<PropertyType> GetPropertyTypesWithValues();

    }
}
