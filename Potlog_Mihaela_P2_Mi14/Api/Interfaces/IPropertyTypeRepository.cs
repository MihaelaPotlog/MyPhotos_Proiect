using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPhotosApi.Api
{
    public interface IPropertyTypeRepository
    {
        Task<PropertyType> Get(int id);
        Task<bool> AddPropertyType(string name);
        IList<PropertyType> GetAll();
    }
}
