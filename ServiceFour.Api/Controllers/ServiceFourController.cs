using Microsoft.AspNetCore.Mvc;

namespace ServiceFour.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ServiceFourController : ControllerBase
    {
        [HttpGet]
        public IActionResult ServiceFourGet()
        {
            return Ok("I am Service Four");
        }
    }
}
