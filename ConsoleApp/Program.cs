using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotosApi;
using MyPhotosApi.Api.Interfaces;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhotoService = new MyPhotosService();
            // myPhotoService.FileService.GetDirectoryPhotosVideos("C:\\Users\\mihaela\\Desktop\\movie photos");
            myPhotoService.TryThings();
        }


    }
}
