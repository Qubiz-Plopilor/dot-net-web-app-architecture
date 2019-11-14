using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace WebApp.API.Infrastructure.Middlewares
{
    public class CustomTestMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomTestMiddleware> _logger;

        public CustomTestMiddleware(RequestDelegate next, ILogger<CustomTestMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("CustomTestMiddleware");
        }        
    }
}
