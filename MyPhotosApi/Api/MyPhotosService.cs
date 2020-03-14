using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosApi.Api.Interfaces
{
    public class MyPhotosService : IMyPhotosService
    {
        public IFileService FileService { get; private set; }
        public IPropertyTypeService PropertyTypeService { get; private set; }
        private MyPhotosContext context;

        public MyPhotosService()
        {
            MyPhotosContext myPhotosContext = new MyPhotosContext();
            context = myPhotosContext;
            FileService = new FileService(myPhotosContext);
            PropertyTypeService = new PropertyTypeService(myPhotosContext);
        }
        public void TryThings()
        {
            MediaFile newFile = new MediaFile()
            {
                Name = "Hello",
                Path = "hello",
                Date = DateTime.Now,
                Erased = false,
                Type = false
                
            };
            context.MediaFiles.Add(newFile);
            PropertyType newPropertyType = new PropertyType()
            {
                Name = "LOCURI"
                
            };
            context.PropertyTypes.Add(newPropertyType);
            PropertyValue newPropertyValue = new PropertyValue()
            {
                Value = "Iasi",
                PropertyTypeId = newPropertyType.Id
                
            };
            context.PropertyValues.Add(newPropertyValue);
            Console.WriteLine(newFile.Id);
            context.SaveChanges();

            Console.ReadKey();

        }
    }
}

