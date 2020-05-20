using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_Interface.Models
{
    public class MediaFile
    {
      
        public int Id { get; set; }
        
        public string Path { get; set; }
    
        public string Name { get; set; }
        
        public bool Type { get; set; }
        
        public DateTime Date { get; set; }

        public IList<Property> Properties { get; set; }
    }
}
