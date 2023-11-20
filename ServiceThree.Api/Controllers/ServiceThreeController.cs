using Microsoft.AspNetCore.Mvc;

namespace ServiceThree.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ServiceThreeController : ControllerBase
    {
        [HttpGet]
        public IActionResult ServiceThreeGet()
        {
            return Ok("I am Service Three");
        }
    }
}
