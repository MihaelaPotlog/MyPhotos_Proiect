using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_Interface.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceReferenceMyPhotos;
namespace AspNetCore_Interface.Pages.Photos
{
    public class IndexModel : PageModel
    {
        MyPhotosServiceClient myPhotosService = new MyPhotosServiceClient();
        public SelectList PropertyTypes { get; set; }
        public List<MediaFile> MediaFiles { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ChosenPropertyType { get; set; }

        private readonly IMapper _mapper;
        public int SearchCount { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public IndexModel(IMapper mapper)
        {
            _mapper = mapper;
            MediaFiles = new List<MediaFile>();
            
        }
        public async Task  OnGetAsync()
        {
            var mediaFiles = await myPhotosService.GetAllAsync();
            PropertyTypes = new SelectList((await myPhotosService.GetAllPropertiesTypesAsync())
                                                    .Select(propertyType =>
                                                         propertyType.Name)
                                                    .ToList()
                                            );
            Console.WriteLine(MediaFiles.Count);
            MediaFiles = _mapper.Map<List<MediaFile>>(mediaFiles);

            if (!string.IsNullOrEmpty(ChosenPropertyType))
            {
                MediaFiles = MediaFiles.FindAll(file => file.Properties
                    .Select(property => property.Type+property.Value)
                    .ToList()
                    .Contains(ChosenPropertyType+SearchString));
               
            }

            SearchCount = MediaFiles.Count;

        }
    }
}