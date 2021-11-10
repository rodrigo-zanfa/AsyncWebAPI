using AsyncWebAPI.ExternalServices;
using AsyncWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JsonPlaceHolderController : ControllerBase
    {
        private readonly IJsonPlaceHolderExternalService _jsonPlaceHolderExternalService;

        public JsonPlaceHolderController(IJsonPlaceHolderExternalService jsonPlaceHolderExternalService)
        {
            _jsonPlaceHolderExternalService = jsonPlaceHolderExternalService;
        }

        [HttpGet("GetAllSync")]
        public IActionResult GetAllSync()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var posts = _jsonPlaceHolderExternalService.GetPosts();
            var comments = _jsonPlaceHolderExternalService.GetComments();
            var albums = _jsonPlaceHolderExternalService.GetAlbums();
            var photos = _jsonPlaceHolderExternalService.GetPhotos();
            var todos = _jsonPlaceHolderExternalService.GetTodos();
            var users = _jsonPlaceHolderExternalService.GetUsers();

            stopwatch.Stop();

            var response = new Response
            {
                Posts = posts,
                Comments = comments,
                Albums = albums,
                Photos = photos,
                Todos = todos,
                Users = users,
                TempoDeExecucaoEmSegundos = stopwatch.Elapsed.TotalSeconds
            };

            return Ok(response);
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var posts = await _jsonPlaceHolderExternalService.GetPostsAsync();
            var comments = await _jsonPlaceHolderExternalService.GetCommentsAsync();
            var albums = await _jsonPlaceHolderExternalService.GetAlbumsAsync();
            var photos = await _jsonPlaceHolderExternalService.GetPhotosAsync();
            var todos = await _jsonPlaceHolderExternalService.GetTodosAsync();
            var users = await _jsonPlaceHolderExternalService.GetUsersAsync();

            stopwatch.Stop();

            var response = new Response
            {
                Posts = posts,
                Comments = comments,
                Albums = albums,
                Photos = photos,
                Todos = todos,
                Users = users,
                TempoDeExecucaoEmSegundos = stopwatch.Elapsed.TotalSeconds
            };

            return Ok(response);
        }

        [HttpGet("GetAllAsyncBetter")]
        public async Task<IActionResult> GetAllAsyncBetter()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var posts = _jsonPlaceHolderExternalService.GetPostsAsync();
            var comments = _jsonPlaceHolderExternalService.GetCommentsAsync();
            var albums = _jsonPlaceHolderExternalService.GetAlbumsAsync();
            var photos = _jsonPlaceHolderExternalService.GetPhotosAsync();
            var todos = _jsonPlaceHolderExternalService.GetTodosAsync();
            var users = _jsonPlaceHolderExternalService.GetUsersAsync();

            //stopwatch.Stop();

            var response = new Response
            {
                Posts = await posts,
                Comments = await comments,
                Albums = await albums,
                Photos = await photos,
                Todos = await todos,
                Users = await users,
                TempoDeExecucaoEmSegundos = stopwatch.Elapsed.TotalSeconds
            };

            stopwatch.Stop();

            return Ok(response);
        }
    }
}
