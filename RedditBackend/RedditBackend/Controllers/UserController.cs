using Microsoft.AspNetCore.Mvc;
using RedditBackend.Dtos;
using RedditBackend.Services;

namespace RedditBackend.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUsersService _usersService;

        public UserController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost]
        public ActionResult Create([FromBody] UserRequestDto user)
        {
            return Created("created", _usersService.CreateUser(user));
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok(_usersService.Index());
        }
    }
}
