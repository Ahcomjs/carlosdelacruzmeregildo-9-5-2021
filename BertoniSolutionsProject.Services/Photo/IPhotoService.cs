using BertoniSolutionsProject.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniSolutionsProject
{
    public interface IPhotoService
    {
        Task<List<Photo>> GetByAlbumId(int AlbumId);
        Task<Photo> GetById(int PhotoId);
    }
}
