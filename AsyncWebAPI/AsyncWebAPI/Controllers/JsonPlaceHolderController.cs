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
            var stopwatchTotal = new Stopwatch();
            stopwatchTotal.Start();

            var stopwatchPosts = new Stopwatch();
            stopwatchPosts.Start();
            var posts = _jsonPlaceHolderExternalService.GetPosts();
            stopwatchPosts.Stop();

            var stopwatchComments = new Stopwatch();
            stopwatchComments.Start();
            var comments = _jsonPlaceHolderExternalService.GetComments();
            stopwatchComments.Stop();

            var stopwatchAlbums = new Stopwatch();
            stopwatchAlbums.Start();
            var albums = _jsonPlaceHolderExternalService.GetAlbums();
            stopwatchAlbums.Stop();

            var stopwatchPhotos = new Stopwatch();
            stopwatchPhotos.Start();
            var photos = _jsonPlaceHolderExternalService.GetPhotos();
            photos = _jsonPlaceHolderExternalService.GetPhotos();
            photos = _jsonPlaceHolderExternalService.GetPhotos();
            stopwatchPhotos.Stop();

            var stopwatchTodos = new Stopwatch();
            stopwatchTodos.Start();
            var todos = _jsonPlaceHolderExternalService.GetTodos();
            stopwatchTodos.Stop();

            var stopwatchUsers = new Stopwatch();
            stopwatchUsers.Start();
            var users = _jsonPlaceHolderExternalService.GetUsers();
            stopwatchUsers.Stop();

            stopwatchTotal.Stop();

            var response = new Response
            {
                TempoDeExecucaoEmSegundosPosts = stopwatchPosts.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosComments = stopwatchComments.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosAlbums = stopwatchAlbums.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosPhotos = stopwatchPhotos.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosTodos = stopwatchTodos.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosUsers = stopwatchUsers.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosTotal = stopwatchTotal.Elapsed.TotalSeconds,
                Posts = posts,
                Comments = comments,
                Albums = albums,
                Photos = photos,
                Todos = todos,
                Users = users
            };

            return Ok(response);
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var stopwatchTotal = new Stopwatch();
            stopwatchTotal.Start();

            var stopwatchPosts = new Stopwatch();
            stopwatchPosts.Start();
            var posts = await _jsonPlaceHolderExternalService.GetPostsAsync();
            stopwatchPosts.Stop();

            var stopwatchComments = new Stopwatch();
            stopwatchComments.Start();
            var comments = await _jsonPlaceHolderExternalService.GetCommentsAsync();
            stopwatchComments.Stop();

            var stopwatchAlbums = new Stopwatch();
            stopwatchAlbums.Start();
            var albums = await _jsonPlaceHolderExternalService.GetAlbumsAsync();
            stopwatchAlbums.Stop();

            var stopwatchPhotos = new Stopwatch();
            stopwatchPhotos.Start();
            var photos = await _jsonPlaceHolderExternalService.GetPhotosAsync();
            photos = await _jsonPlaceHolderExternalService.GetPhotosAsync();
            photos = await _jsonPlaceHolderExternalService.GetPhotosAsync();
            stopwatchPhotos.Stop();

            var stopwatchTodos = new Stopwatch();
            stopwatchTodos.Start();
            var todos = await _jsonPlaceHolderExternalService.GetTodosAsync();
            stopwatchTodos.Stop();

            var stopwatchUsers = new Stopwatch();
            stopwatchUsers.Start();
            var users = await _jsonPlaceHolderExternalService.GetUsersAsync();
            stopwatchUsers.Stop();

            stopwatchTotal.Stop();

            var response = new Response
            {
                TempoDeExecucaoEmSegundosPosts = stopwatchPosts.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosComments = stopwatchComments.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosAlbums = stopwatchAlbums.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosPhotos = stopwatchPhotos.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosTodos = stopwatchTodos.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosUsers = stopwatchUsers.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosTotal = stopwatchTotal.Elapsed.TotalSeconds,
                Posts = posts,
                Comments = comments,
                Albums = albums,
                Photos = photos,
                Todos = todos,
                Users = users
            };

            return Ok(response);
        }

        [HttpGet("GetAllAsyncBetter")]
        public async Task<IActionResult> GetAllAsyncBetter()
        {
            var stopwatchTotal = new Stopwatch();
            stopwatchTotal.Start();

            var stopwatchPosts = new Stopwatch();
            stopwatchPosts.Start();
            var posts = _jsonPlaceHolderExternalService.GetPostsAsync();
            //stopwatchPosts.Stop();

            var stopwatchComments = new Stopwatch();
            stopwatchComments.Start();
            var comments = _jsonPlaceHolderExternalService.GetCommentsAsync();
            //stopwatchComments.Stop();

            var stopwatchAlbums = new Stopwatch();
            stopwatchAlbums.Start();
            var albums = _jsonPlaceHolderExternalService.GetAlbumsAsync();
            //stopwatchAlbums.Stop();

            var stopwatchPhotos = new Stopwatch();
            stopwatchPhotos.Start();
            var photos = _jsonPlaceHolderExternalService.GetPhotosAsync();
            photos = _jsonPlaceHolderExternalService.GetPhotosAsync();
            photos = _jsonPlaceHolderExternalService.GetPhotosAsync();
            //stopwatchPhotos.Stop();

            var stopwatchTodos = new Stopwatch();
            stopwatchTodos.Start();
            var todos = _jsonPlaceHolderExternalService.GetTodosAsync();
            //stopwatchTodos.Stop();

            var stopwatchUsers = new Stopwatch();
            stopwatchUsers.Start();
            var users = _jsonPlaceHolderExternalService.GetUsersAsync();
            //stopwatchUsers.Stop();

            //stopwatchTotal.Stop();

            var response = new Response
            {
                Posts = await posts,
                Comments = await comments,
                Albums = await albums,
                Photos = await photos,
                Todos = await todos,
                Users = await users,
                TempoDeExecucaoEmSegundosPosts = stopwatchPosts.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosComments = stopwatchComments.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosAlbums = stopwatchAlbums.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosPhotos = stopwatchPhotos.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosTodos = stopwatchTodos.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosUsers = stopwatchUsers.Elapsed.TotalSeconds,
                TempoDeExecucaoEmSegundosTotal = stopwatchTotal.Elapsed.TotalSeconds
            };

            stopwatchPosts.Stop();
            stopwatchComments.Stop();
            stopwatchAlbums.Stop();
            stopwatchPhotos.Stop();
            stopwatchTodos.Stop();
            stopwatchUsers.Stop();
            stopwatchTotal.Stop();

            return Ok(response);
        }
    }
}
