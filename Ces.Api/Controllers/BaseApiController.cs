using Ces.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ces.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
        protected IActionResult OkResponse<T>(T data, string? message = null)
            => Ok(ApiResponse<T>.Ok(data, message));

        protected IActionResult CreatedResponse<T>(T data, string? message = null)
            => StatusCode(201, ApiResponse<T>.Ok(data, message));

        protected IActionResult ErrorResponse(
            string message,
            object? errors = null,
            int statusCode = 400)
            => StatusCode(statusCode, ApiResponse<object>.Fail(message, errors));
    }
}
