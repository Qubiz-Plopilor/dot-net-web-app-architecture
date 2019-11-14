using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toucan.API.Infrastructure.Middlewares;

namespace WebApp.API.Infrastructure.Middlewares
{
    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseApiExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ApiExceptionMiddleware>();

            return app;
        }
    }
}
