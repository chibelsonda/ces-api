using Ces.Api.Models;

namespace Ces.Api.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";

                var response = ApiResponse<object>.Fail(
                    "An unexpected error occurred"
                );

                await context.Response.WriteAsJsonAsync(response);
            }
        }
    }
}
