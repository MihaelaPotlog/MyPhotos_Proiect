using System.Collections.Generic;

namespace MyPhotosApi.Api.DTOs.RequestDtos
{
    public class ModifyFileDto
    {
        public int FileId { get; set; }
        public IDictionary<int, string> AddedPropertiesInfo { get; set; }
        public IDictionary<int, string> DeletedPropertiesInfo { get; set; }

        public ModifyFileDto()
        {
            AddedPropertiesInfo = new Dictionary<int, string>();
            DeletedPropertiesInfo = new Dictionary<int, string>();
        }
    }
}
