using AutoMapper;
using MyPhotosApi.Api.Repositories;
using MyPhotosApi.Services;

namespace MyPhotosApi.Api.Interfaces
{
    public class MyPhotosApi 
    {
        public IMediaFileService MediaFileService { get; private set; }
        public IPropertyTypeService PropertyTypeService { get; private set; }
        
        

        public MyPhotosApi()
        {
            // IMapper mapper = new AutoMapper();
            MyPhotosContext myPhotosContext = new MyPhotosContext();
            MediaFileRepository mediaFileRepository = new MediaFileRepository(myPhotosContext);
            PropertyValueRepository propertyValueRepository = new PropertyValueRepository(myPhotosContext);
            PropertyTypeRepository propertyTypeRepository =  new PropertyTypeRepository(myPhotosContext);

            MyPhotosWrapper myPhotosWrapper = new MyPhotosWrapper(mediaFileRepository, propertyValueRepository, propertyTypeRepository);
            IMapper mapper = AutomapperConfigure.Mapper;
            MediaFileService = new MediaFileService(myPhotosWrapper, mapper);
            PropertyTypeService = new PropertyTypeService(myPhotosWrapper, mapper);
        }
       
    }
}

