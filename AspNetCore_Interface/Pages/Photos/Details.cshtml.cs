using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_Interface.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMyPhotos;

namespace AspNetCore_Interface.Pages.Photos
{
    public class DetailsModel : PageModel
    {
        MyPhotosServiceClient myPhotosService = new MyPhotosServiceClient();
        private readonly IMapper _mapper;
        public MediaFile MediaFile { get; set; }
        public IList<Property> MediaFileProperties { get; set; }

        public DetailsModel(IMapper mapper)
        {
            _mapper = mapper;
            MediaFileProperties = new List<Property>();
        }
        public async Task OnGetAsync(int? id)
        {
            var mediaFiles = await myPhotosService.GetAllAsync();
            var mediaFile = mediaFiles.Find(mediaFile => mediaFile.Id == id);
            
            MediaFileProperties = _mapper.Map<List<Property>>(mediaFile.Properties);
            MediaFileProperties = MediaFileProperties.OrderBy(property => property.Value).ToList();
            MediaFile = _mapper.Map<MediaFile>(mediaFile);
            int relativePathStartIndex = MediaFile.Path.IndexOf("photos");
            if (relativePathStartIndex != -1)
            {
                MediaFile.Path = MediaFile.Path.Substring(relativePathStartIndex);
            }
            
            MediaFile.Path = MediaFile.Path.Replace("\\", "/");
            MediaFile.Path = "~/" + MediaFile.Path;
        }
    }
}