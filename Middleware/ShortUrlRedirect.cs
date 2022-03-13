using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ShotenerBlazor.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ShotenerBlazor.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ShortUrlRedirect
    {
        private readonly RequestDelegate _next;

        public ShortUrlRedirect(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, ShotenerDataContext context)
        {
            
            if (httpContext.Request.Path.ToString().Length == 9)
            {
                var token = httpContext.Request.Path.ToString().Substring(1);
                var shortUrl = context.ShortUrls.FirstOrDefault(su => su.Token == token);
                if (shortUrl != null)
                {
                    httpContext.Response.Redirect(shortUrl.OriginalUrl.ToString());
                }
                else
                    httpContext.Response.Redirect(httpContext.Request.Host.ToString());
            }

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ShortUrlRedirectExtensions
    {
        public static IApplicationBuilder UseShortUrlRedirect(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ShortUrlRedirect>();
        }
    }
}
