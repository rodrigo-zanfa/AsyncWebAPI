using AsyncWebAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncWebAPI.ExternalServices
{
    public class JsonPlaceHolderExternalService : IJsonPlaceHolderExternalService
    {
        private readonly HttpClient _httpClient;

        public JsonPlaceHolderExternalService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
        }


        #region Sync

        public IEnumerable<Post> GetPosts()
        {
            var responseMessage = _httpClient.GetAsync($"posts/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var posts = JsonConvert.DeserializeObject<IEnumerable<Post>>(responseText);
            return posts;
        }

        public IEnumerable<Comment> GetComments()
        {
            var responseMessage = _httpClient.GetAsync($"comments/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var comments = JsonConvert.DeserializeObject<IEnumerable<Comment>>(responseText);
            return comments;
        }

        public IEnumerable<Album> GetAlbums()
        {
            var responseMessage = _httpClient.GetAsync($"albums/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(responseText);
            return albums;
        }

        public IEnumerable<Photo> GetPhotos()
        {
            var responseMessage = _httpClient.GetAsync($"photos/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var photos = JsonConvert.DeserializeObject<IEnumerable<Photo>>(responseText);
            return photos;
        }

        public IEnumerable<Todo> GetTodos()
        {
            var responseMessage = _httpClient.GetAsync($"todos/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var todos = JsonConvert.DeserializeObject<IEnumerable<Todo>>(responseText);
            return todos;
        }

        public IEnumerable<User> GetUsers()
        {
            var responseMessage = _httpClient.GetAsync($"users/?nocache={Guid.NewGuid()}").Result;
            var responseText = responseMessage.Content.ReadAsStringAsync().Result;
            var users = JsonConvert.DeserializeObject<IEnumerable<User>>(responseText);
            return users;
        }

        #endregion


        #region Async

        public async Task<IEnumerable<Post>> GetPostsAsync()
        {
            var responseMessage = await _httpClient.GetAsync($"posts/?nocache={Guid.NewGuid()}");
            var responseText = await responseMessage.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<IEnumerable<Post>>(responseText);
            return posts;
        }

        public async Task<IEnumerable<Comment>> GetCommentsAsync()
        {
            var responseMessage = await _httpClient.GetAsync($"comments/?nocache={Guid.NewGuid()}");
            var responseText = await responseMessage.Content.ReadAsStringAsync();
            var comments = JsonConvert.DeserializeObject<IEnumerable<Comment>>(responseText);
            return comments;
        }

        public async Task<IEnumerable<Album>> GetAlbumsAsync()
        {
            var responseMessage = await _httpClient.GetAsync($"albums/?nocache={Guid.NewGuid()}");
            var responseText = await responseMessage.Content.ReadAsStringAsync();
            var albums = JsonConvert.DeserializeObject<IEnumerable<Album>>(responseText);
            return albums;
        }

        public async Task<IEnumerable<Photo>> GetPhotosAsync()
        {
            var responseMessage = await _httpClient.GetAsync($"photos/?nocache={Guid.NewGuid()}");
            var responseText = await responseMessage.Content.ReadAsStringAsync();
            var photos = JsonConvert.DeserializeObject<IEnumerable<Photo>>(responseText);
            return photos;
        }

        public async Task<IEnumerable<Todo>> GetTodosAsync()
        {
            var responseMessage = await _httpClient.GetAsync($"todos/?nocache={Guid.NewGuid()}");
            var responseText = await responseMessage.Content.ReadAsStringAsync();
            var todos = JsonConvert.DeserializeObject<IEnumerable<Todo>>(responseText);
            return todos;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var responseMessage = await _httpClient.GetAsync($"users/?nocache={Guid.NewGuid()}");
            var responseText = await responseMessage.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<IEnumerable<User>>(responseText);
            return users;
        }

        #endregion
    }
}
