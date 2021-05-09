using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniSolutionsProject.ViewModels
{
    public class PhotoVM
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
        public List<CommentVM> Comments { get; set; }
    }
}
