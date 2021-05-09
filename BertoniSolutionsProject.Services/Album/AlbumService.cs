using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BertoniSolutionsProject.Entities.Models;

namespace BertoniSolutionsProject
{
    public class AlbumService : IAlbumService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AlbumService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Album>> GetAll()
        {
            var client =  _httpClientFactory.CreateClient("Api");

            var result = await client.GetAsync("/albums");

            var response = await result.Content.ReadAsStringAsync();

            List<Album> albums = JsonConvert.DeserializeObject<List<Album>>(response);

            return albums;
            
        }
        
        
    }
}
