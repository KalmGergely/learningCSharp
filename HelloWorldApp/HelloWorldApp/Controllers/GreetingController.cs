using Microsoft.AspNetCore.Mvc;
using HelloWorldApp.Models;

namespace HelloWorldApp.Controllers
{
    [Route("api")]
    public class GreetingController : Controller
    {
        [HttpGet("greeting")]
        public ActionResult Greeting()
        {
            Greeting response = new Greeting() { Id = 1, Content = "Hello World!" };

            return Ok(response);
        }
        
        [HttpGet("greeting/{name}")]
        public ActionResult GreetByName(string name) 
        {
            Greeting response = new Greeting() { Id = 1, Content = $"Hello {name}" };

            return Ok(response);
        }

        [HttpGet("greetspec/{name}/")]
        public ActionResult GreetSpecifically(string name, [FromQuery(Name = "greeting")] string greeting)
        {
            Greeting response = new Greeting() { Id = 1, Content = $"{greeting} {name}" };

            return Ok(response);
        }
    }
}
