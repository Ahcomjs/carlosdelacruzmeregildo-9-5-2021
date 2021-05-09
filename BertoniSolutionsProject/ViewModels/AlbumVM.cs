using System.Collections.Generic;

namespace BertoniSolutionsProject.ViewModels
{
    public class AlbumVM
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }

        public List<PhotoVM> Photos { get; set; }
    }
}
