using AutoMapper;
using BertoniSolutionsProject.Entities.Models;
using BertoniSolutionsProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniSolutionsProject.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAlbumService _albumService;
        private readonly IPhotoService _photoService;
    

        public GalleryController(IMapper mapper, IAlbumService albumService, IPhotoService photoService)
        {
            _mapper = mapper;
            _albumService = albumService;
            _photoService = photoService;
        }

        public async Task<IActionResult> Index()
        {
            List<Album> albums = await _albumService.GetAll();

            List<AlbumVM> albumsVM = _mapper.Map<List<AlbumVM>>(albums);

            return View(albumsVM);
        }


        public async Task<IActionResult> Photos(int Id)
        {
            List<Photo> photos = await _photoService.GetByAlbumId(Id);
            List<PhotoVM> photosVM = _mapper.Map<List<PhotoVM>>(photos);

            return View(photosVM);
        }
    }
}
