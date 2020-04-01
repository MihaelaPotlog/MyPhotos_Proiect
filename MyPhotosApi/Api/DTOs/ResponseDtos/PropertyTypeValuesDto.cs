using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyPhotosApi.Api.DTOs
{
    [DataContract(IsReference = true)]
    public class PropertyTypeValuesDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public IList<string> Values { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
