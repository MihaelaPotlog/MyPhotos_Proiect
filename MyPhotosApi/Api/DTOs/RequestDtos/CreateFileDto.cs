using System.Collections.Generic;

namespace MyPhotosApi.Api
{
    public class CreateFileDto
    {
        public string Path { get; set; }
        
        public IDictionary<int, IList<string>> Properties { get; set; }

        public CreateFileDto()
        {
            Properties = new Dictionary<int, IList<string>>();
        }
    }
}
