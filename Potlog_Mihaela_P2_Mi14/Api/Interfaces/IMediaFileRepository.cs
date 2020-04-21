using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosApi.Api.Interfaces
{
    interface IMediaFileRepository
    {

        Task<MediaFile> Get(int id);

        Task Delete(int id);

        IList<MediaFile> GetAll();

        Task CommitAsync();
        // Task Update(MediaFile mediaFile);

        Task Add(MediaFile mediaFile);

        MediaFile GetByPath(string path);

        IList<MediaFile> FindManyByProperty(int propertyTypeId, string propertyValue);
    }
}
