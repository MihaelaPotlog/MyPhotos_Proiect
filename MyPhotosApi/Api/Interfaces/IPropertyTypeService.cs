using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosApi.Api
{
    public interface IPropertyTypeService
    {
        bool AddCharacteristicType(string name);
        IList<string> GetCharacteristicTypes();

    }
}
