using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RedditBackend;
using RedditBackend.Models;
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
        public ActionResult Create([FromBody] Post post)
        {
            return Created("Created", _postsService.CreatePost(post));
        }
    }
}
