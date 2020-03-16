using AutoMapper;
using MyPhotosApi.Api.Repositories;
using MyPhotosApi.Services;

namespace MyPhotosApi.Api.Interfaces
{
    public class MyPhotosApi 
    {
        public IMediaFileService MediaFileService { get; }
        public IPropertyTypeService PropertyTypeService { get; }
        
        public MyPhotosApi()
        {
            
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

