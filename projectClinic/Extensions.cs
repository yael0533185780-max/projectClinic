using Microsoft.AspNetCore.Builder;
using projectClinic.Middleware;

namespace projectClinic
{
    public static class Extensions
    {
        public static IApplicationBuilder UseShabbatMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ShabbatMiddleware>();
        }
    }
}
