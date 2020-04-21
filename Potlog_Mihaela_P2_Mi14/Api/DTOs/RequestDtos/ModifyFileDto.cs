using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyPhotosApi.Api.DTOs.RequestDtos
{
    [DataContract(IsReference = true)]
    public class ModifyFileDto
    {
        [DataMember]
        public int FileId { get; set; }
        [DataMember]
        public IDictionary<int, string> AddedPropertiesInfo { get; set; }
        [DataMember]
        public IDictionary<int, string> DeletedPropertiesInfo { get; set; }

        public ModifyFileDto()
        {
            AddedPropertiesInfo = new Dictionary<int, string>();
            DeletedPropertiesInfo = new Dictionary<int, string>();
        }
    }
}
