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
            return await _myPhotosContext.MediaFiles.FindAsync(id);
        }

        public async Task Delete(int id)
        {
            var mediaFile = await _myPhotosContext.MediaFiles.FindAsync(id);
            if (mediaFile != null)
            {

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

        public async Task Update()
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
                                                                     elem.Value == propertyValue) != default(PropertyValue) && file.Erased == false).ToList();
            
        }
    }
}
