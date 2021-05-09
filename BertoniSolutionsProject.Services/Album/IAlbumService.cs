using System.Collections.Generic;
using BertoniSolutionsProject.Entities.Models;
using System.Threading.Tasks;

namespace BertoniSolutionsProject
{
    public interface IAlbumService
    {
        Task<List<Album>> GetAll();
    }
}
