using Microsoft.AspNetCore.Mvc;

namespace ServiceOne.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ServiceOneController : ControllerBase
    {
        [HttpGet]
        public IActionResult ServiceOneGet()
        {
            return Ok("I am Service One");
        }
    }
}
