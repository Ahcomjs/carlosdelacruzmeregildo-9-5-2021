using BertoniSolutionsProject.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniSolutionsProject
{
    public interface ICommentService
    {
        Task<List<Comment>> GetByPhotoId(int PhotoId);
    }
}
