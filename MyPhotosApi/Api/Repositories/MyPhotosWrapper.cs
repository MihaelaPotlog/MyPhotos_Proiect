namespace MyPhotosApi.Api.Repositories
{
    public class MyPhotosWrapper
    {
        internal PropertyValueRepository PropertyValues { get; set; }
        internal MediaFileRepository MediaFiles { get; set; }
        internal PropertyTypeRepository PropertyTypes { get; set; }


        internal MyPhotosWrapper(MediaFileRepository mediaFiles, PropertyValueRepository propertyValues, PropertyTypeRepository propertyTypes)
        {
            PropertyValues = propertyValues;
            MediaFiles = mediaFiles;
            PropertyTypes = propertyTypes;
        }
    }
}
