using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AspNetCore_Interface.Models;
using AutoMapper;
using ServiceReferenceMyPhotos;

namespace AspNetCore_Interface.MappingDtos
{
    public class MediaFileProfile: Profile
    {
        public MediaFileProfile()
        {
            CreateMap<FileDto, MediaFile>()
                .ForMember(dest => dest.Path, opt => opt.MapFrom(
                    src => Path.Combine("\\MyPhotos", src.Path.Substring(37)))
                );
        }
    }
}
