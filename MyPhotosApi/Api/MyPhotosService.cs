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
            File newFile = new File()
            {
                Name = "Hello",
                Path = "hello",
                Date = DateTime.Now,
                Erased = false,
                Type = false,
                Id = Guid.NewGuid()
            };
            context.Files.Add(newFile);
            PropertyType newPropertyType = new PropertyType()
            {
                Name = "LOCURI",
                Id = Guid.NewGuid()
            };
            context.PropertyTypes.Add(newPropertyType);
            PropertyValue newPropertyValue = new PropertyValue()
            {
                Value = "Iasi",
                PropertyTypeId = newPropertyType.Id,
                Id = Guid.NewGuid()
            };
            context.PropertyValues.Add(newPropertyValue);
            Console.WriteLine(newFile.Id);
            context.SaveChanges();

            Console.ReadKey();

        }
    }
}

