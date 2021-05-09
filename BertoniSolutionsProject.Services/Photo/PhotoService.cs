using BertoniSolutionsProject.Entities.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BertoniSolutionsProject
{
    public class PhotoService : IPhotoService
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public PhotoService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Photo>> GetByAlbumId(int AlbumId)
        {

            var client = _httpClientFactory.CreateClient("Api");

            var resultPhoto = await client.GetAsync("/photos");

            string responsePhoto = await resultPhoto.Content.ReadAsStringAsync();
            List<Photo> photos = JsonConvert.DeserializeObject<List<Photo>>(responsePhoto)
                                 .Where(photo => photo.AlbumId == AlbumId).ToList();

            var resultComment = await client.GetAsync("/comments");
            var responseComment = await resultComment.Content.ReadAsStringAsync();
            List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(responseComment).ToList();

            List<Photo> response = new List<Photo>();
            foreach (var photo in photos)
            {
                photo.Comments = comments.Where(y => y.PostId == photo.Id).ToList();
                response.Add(photo);
            };

            return response;
        }

        public async Task<Photo> GetById(int PhotoId)
        {
            var client = _httpClientFactory.CreateClient("Api");

            var result = await client.GetAsync("/photos");

            var response = await result.Content.ReadAsStringAsync();

            Photo photo = JsonConvert.DeserializeObject<List<Photo>>(response)
                          .Where(photo => photo.Id == PhotoId).FirstOrDefault();

            return photo;
        }
    }
}
