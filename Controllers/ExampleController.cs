using Microsoft.AspNetCore.Mvc;

namespace finwise_web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController : ControllerBase
    {
        public IActionResult GetMessage()
        {
            return Ok("ExampleController çalışıyor!");
        }
    }
}
