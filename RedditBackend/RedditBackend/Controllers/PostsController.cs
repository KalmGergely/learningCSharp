using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RedditBackend;
using RedditBackend.Models;
using RedditBackend.Dtos;
using RedditBackend.Services;

namespace RedditBackend.Controllers
{
    [Route("api/posts")]
    public class PostsController : Controller
    {
        private readonly IPostsService _postsService;

        public PostsController(IPostsService postsService)
        {
            _postsService = postsService;
        }

        // GET: Posts
        [HttpGet]
        public ActionResult Index()
        {
            return Ok(_postsService.IndexPosts());
        }

        // POST: Posts
        [HttpPost]
        public ActionResult Create([FromBody] PostRequestDto post, [FromHeader] int UserId)
        {
            return Created("Created", _postsService.CreatePost(post, UserId));
        }

        // PATCH: Posts
        [HttpPatch("{id}")]
        public ActionResult UpdatePost(int id, [FromBody] PostRequestDto post)
        {
            return Ok(_postsService.UpdatePost(id, post));
        }

        //DELETE: Posts
        [HttpDelete("{id}")]
        public ActionResult DeletePost(int id)
        {
            _postsService.DeletePost(id);
            return NoContent();
        }
    }
}
