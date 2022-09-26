using CustomMiddleware.Middlewares;

namespace CustomMiddleware.Extensions
{
    public static class MiddlewareExtensions
    {

        public static IApplicationBuilder UseRateLimiting(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RateLimitingMiddleware>();
        }
    }
}
