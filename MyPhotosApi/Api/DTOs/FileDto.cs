using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace MyPhotosApi.Api
{
    public class FileDto
    {
        public string Path { get; set; }
        public IList<Guid> PropertyValues { get; set; }
        public IDictionary<Guid,IList<string>> NewPropertyValues { get; set; }
    }
}
