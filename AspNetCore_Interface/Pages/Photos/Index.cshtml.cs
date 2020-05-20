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
    public class IndexModel : PageModel
    {
        MyPhotosServiceClient myPhotosService = new MyPhotosServiceClient();
        public List<MediaFile> MediaFiles { get; set; }
        private readonly IMapper _mapper;

        public IndexModel(IMapper mapper)
        {
            _mapper = mapper;
            MediaFiles = new List<MediaFile>();
        }
        public async Task  OnGetAsync()
        {
            var mediaFiles = await myPhotosService.GetAllAsync();
            Console.WriteLine(MediaFiles.Count);
            MediaFiles = _mapper.Map<List<MediaFile>>(mediaFiles);
        }
    }
}