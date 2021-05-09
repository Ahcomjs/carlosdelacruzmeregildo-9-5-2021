using BertoniSolutionsProject.Entities.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BertoniSolutionsProject
{
    public class CommentService : ICommentService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CommentService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Comment>> GetByPhotoId(int PhotoId)
        {
            var client = _httpClientFactory.CreateClient("Api");

            var result = await client.GetAsync("/comments");

            string response = await result.Content.ReadAsStringAsync();

            List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(response)
                                    .Where(comment => comment.PostId == PhotoId).ToList();

            return comments;
        }
    }
}
