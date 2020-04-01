using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MyPhotosApi.Api.DTOs.ResponseDtos;

namespace MyPhotosApi.Api.DTOs
{
    [DataContract(IsReference = true)]
    public class FileDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool Type { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public IList<PropertyDto> Properties { get; set; }
       
    }
}
