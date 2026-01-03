using Ces.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ces.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public abstract class BaseApiController : ControllerBase
    {
        protected IActionResult OkResponse<T>(T data, string? message = null)
        {
            return Ok(ApiResponse<T>.Ok(data, message));
        }

        protected IActionResult CreatedResponse<T>(T data, string? message = null)
        {
            return StatusCode(201, ApiResponse<T>.Ok(data, message));
        }

        protected IActionResult ErrorResponse(string message, object? errors = null, int statusCode = 400)
        {
            return StatusCode(statusCode, ApiResponse<object>.Fail(message, errors));
        }
    }
}
