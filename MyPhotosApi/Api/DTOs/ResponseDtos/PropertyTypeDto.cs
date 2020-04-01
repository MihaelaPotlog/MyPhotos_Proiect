using System.Runtime.Serialization;

namespace MyPhotosApi.Api.DTOs
{
    [DataContract(IsReference = true)]
    public class PropertyTypeDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
