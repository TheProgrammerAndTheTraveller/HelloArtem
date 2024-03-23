using Microsoft.AspNetCore.Mvc;

namespace HelloArtem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Hui()
        {
            return Ok("Hello Artem");
        }
    }
}
