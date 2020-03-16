using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosApi.Api.Repositories
{
    class MediaFileRepository
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

        public IList<MediaFile> GetAll()
        {
            return _myPhotosContext.MediaFiles.ToList();
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
            return _myPhotosContext.MediaFiles.FirstOrDefault(file => file.Path == path);
        }

        public IList<MediaFile> FindManyByProperty(int propertyTypeId, string propertyValue)
        {
            return _myPhotosContext.MediaFiles
                .Where(file => file.PropertyValues
                                   .FirstOrDefault(elem => elem.PropertyTypeId == propertyTypeId &&
                                                                     elem.Value == propertyValue) != default(PropertyValue)).ToList();
            
        }
    }
}
