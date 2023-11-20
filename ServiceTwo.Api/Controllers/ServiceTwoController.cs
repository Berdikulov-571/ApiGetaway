using Microsoft.AspNetCore.Mvc;

namespace ServiceTwo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ServiceTwoController : ControllerBase
    {
        [HttpGet]
        public IActionResult ServiceTwoGet()
        {
            return Ok("I am Service Two");
        }
    }
}