using System.Collections.Generic;

namespace MyPhotosApi.Api.DTOs
{
    public class PropertyTypeValuesDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public IList<string> Values { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
