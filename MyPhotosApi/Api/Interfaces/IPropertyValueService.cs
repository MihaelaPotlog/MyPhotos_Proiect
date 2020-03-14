using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosApi.Api.Interfaces
{
    internal interface IPropertyValueService
    {
        Task AddOnePropertyValue(int propertyTypeId, string value);
        Task AddManyPropertyValues(int propertyTypeId, IList<string> propertyValues);

    }
}
