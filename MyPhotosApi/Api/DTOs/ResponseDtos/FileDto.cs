using System;
using System.Collections.Generic;
using MyPhotosApi.Api.DTOs.ResponseDtos;

namespace MyPhotosApi.Api.DTOs
{
    public class FileDto
    {
        
        public int Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public bool Type { get; set; }
        
        public DateTime Date { get; set; }


        public IList<PropertyDto> Properties { get; set; }
       
    }
}
