using Microsoft.AspNetCore.Mvc;

namespace Ces.Api.Controllers
{
    [ApiVersion("1.0")]
    public class TestController : BaseApiController
    {
        [HttpGet]
        public IActionResult Test()
        {
            return OkResponse(
                data: new { timestamp = DateTime.UtcNow },
                message: "CES API is running successfully 🚀"
            );
        }
    }
}
