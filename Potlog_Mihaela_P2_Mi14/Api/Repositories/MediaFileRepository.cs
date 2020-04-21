using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using MyPhotosApi.Api.Interfaces;

namespace MyPhotosApi.Api.Repositories
{
    class MediaFileRepository:IMediaFileRepository
    {
        private MyPhotosContext _myPhotosContext;

        public MediaFileRepository(MyPhotosContext myPhotosContext)
        {
            _myPhotosContext = myPhotosContext;
        }

        public async Task<MediaFile> Get(int id)
        {
            var searchedMediaFile = await _myPhotosContext.MediaFiles.FindAsync(id);
            await _myPhotosContext.Entry(searchedMediaFile).Collection(mediaFile => mediaFile.PropertyValues)
                .LoadAsync();
            return searchedMediaFile;
        }

        public async Task Delete(int id)
        {
            var mediaFile = await _myPhotosContext.MediaFiles.FindAsync(id);
            if (mediaFile != null)
            {
                mediaFile.Erased = true;
            }
        }

        public IList<MediaFile> GetAll()
        {
            return _myPhotosContext.MediaFiles
                                    .Where(file=> file.Erased == false)
                                    .Include(file => file.PropertyValues
                                    .Select(propertyValue => propertyValue.PropertyType))
                                    .ToList();
        }

        public async Task CommitAsync()
        {
            await _myPhotosContext.SaveChangesAsync();
        }

        public async Task Add(MediaFile mediaFile)
        {
            _myPhotosContext.MediaFiles.Add(mediaFile);
            await _myPhotosContext.SaveChangesAsync();
        }

        public MediaFile GetByPath(string path)
        {
            return _myPhotosContext.MediaFiles.FirstOrDefault(file => file.Path == path && file.Erased == false);
        }

        public IList<MediaFile> FindManyByProperty(int propertyTypeId, string propertyValue)
        {
            return _myPhotosContext.MediaFiles
                .Where(file => file.PropertyValues
                                   .FirstOrDefault(elem => elem.PropertyTypeId == propertyTypeId &&
                                                                     elem.Value == propertyValue) != default(PropertyValue) && file.Erased == false)
                .Include(file=> file.PropertyValues.Select(currentPropertyValue => currentPropertyValue.PropertyType))
                .ToList();
            
        }

        // public Task Update(MediaFile mediaFile)
        // {
        //
        //     // _myPhotosContext.MediaFiles.Up
        // }
    }
}
