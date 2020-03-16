using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhotoService = new MyPhotosApi.Api.Interfaces.MyPhotosApi();
            // myPhotoService.MediaFileService.GetDirectoryPhotosVideos("C:\\Users\\mihaela\\Desktop\\movie photos");
            var x = myPhotoService.PropertyTypeRepository.GetPropertyTypesWithValues();
            foreach (var propertyType in x)
            {
                Console.WriteLine(propertyType.Name);
                foreach (var value in  propertyType.PropertyValues)
                {
                    
                    Console.WriteLine(value.Value);
                }
            }

            Console.ReadKey();
        }


    }
}
