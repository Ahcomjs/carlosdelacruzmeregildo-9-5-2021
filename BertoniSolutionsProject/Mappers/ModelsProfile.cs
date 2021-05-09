using AutoMapper;
using BertoniSolutionsProject.Entities.Models;
using BertoniSolutionsProject.ViewModels;

namespace BertoniSolutionsProject.Mappers
{
    public class ModelsProfile : Profile
    {
        public ModelsProfile()
        {
            CreateMap<Album, AlbumVM>();
            CreateMap<Photo, PhotoVM>();
            CreateMap<Comment, CommentVM>();
        }
    }
}
