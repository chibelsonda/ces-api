using Microsoft.AspNetCore.Mvc;

namespace Ces.Api.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("api/test")]
        public IActionResult Test()
        {
            return Ok(new
            {
                message = "CES API is running successfully 🚀",
                timestamp = DateTime.UtcNow
            });
        }
    }
}
