using MyPhotosApi.Api.Interfaces;

namespace MyPhotosApi.Api.Repositories
{
    public class MyPhotosWrapper
    {
        internal IPropertyValueRepository PropertyValues { get; set; }
        internal IMediaFileRepository MediaFiles { get; set; }
        internal IPropertyTypeRepository PropertyTypes { get; set; }


        internal MyPhotosWrapper(MediaFileRepository mediaFiles, PropertyValueRepository propertyValues, PropertyTypeRepository propertyTypes)
        {
            PropertyValues = propertyValues;
            MediaFiles = mediaFiles;
            PropertyTypes = propertyTypes;
        }
    }
}
