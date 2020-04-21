using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyPhotosApi.Api
{
    [DataContract(IsReference = true)]
    public class CreateFileDto
    {
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public IDictionary<int, IList<string>> Properties { get; set; }

        public CreateFileDto()
        {
            Properties = new Dictionary<int, IList<string>>();
        }
    }
}
