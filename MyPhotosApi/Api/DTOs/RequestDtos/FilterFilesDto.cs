using System.Runtime.Serialization;

namespace MyPhotosApi.Api.DTOs
{
    [DataContract(IsReference = true)]
    public class FilterFilesDto
    {
        [DataMember]
        public int PropertyTypeId { get; set; }
        [DataMember]
        public string PropertyValue { get; set; }
    }
}
