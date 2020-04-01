using System.Runtime.Serialization;

namespace MyPhotosApi.Api.DTOs.ResponseDtos
{
    [DataContract(IsReference = true)]
    public class PropertyDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Value { get; set; }
    }
}
