using AsyncWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWebAPI.ExternalServices
{
    public interface IJsonPlaceHolderExternalService
    {
        #region Sync

        IEnumerable<Post> GetPosts();
        IEnumerable<Comment> GetComments();
        IEnumerable<Album> GetAlbums();
        IEnumerable<Photo> GetPhotos();
        IEnumerable<Todo> GetTodos();
        IEnumerable<User> GetUsers();

        #endregion


        #region Async

        Task<IEnumerable<Post>> GetPostsAsync();
        Task<IEnumerable<Comment>> GetCommentsAsync();
        Task<IEnumerable<Album>> GetAlbumsAsync();
        Task<IEnumerable<Photo>> GetPhotosAsync();
        Task<IEnumerable<Todo>> GetTodosAsync();
        Task<IEnumerable<User>> GetUsersAsync();

        #endregion
    }
}
