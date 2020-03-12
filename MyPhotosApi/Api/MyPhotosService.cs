using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosApi.Api.Interfaces
{
    public class MyPhotosService : IMyPhotosService
    {
        public IFileService FileService { get; private set; }
        public IPropertyTypeService PropertyTypeService { get; private set; }

        public MyPhotosService()
        {
            MyPhotosContext _myPhotosContext = new MyPhotosContext();
            FileService = new FileService(_myPhotosContext);
            PropertyTypeService = new PropertyTypeService(_myPhotosContext);
        }
    }
}
