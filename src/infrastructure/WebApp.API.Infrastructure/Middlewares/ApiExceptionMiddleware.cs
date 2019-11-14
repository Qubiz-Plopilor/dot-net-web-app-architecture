using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;
using WebApp.API.Infrastructure.Models;
using WebApp.Core.Domain.Contracts.Exceptions;
using WebApp.Utilities;

namespace Toucan.API.Infrastructure.Middlewares
{
    public class ApiExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ApiExceptionMiddleware> _logger;

        public ApiExceptionMiddleware(RequestDelegate next, ILogger<ApiExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception: {ex}");
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;

            if (exception is EntityNotFoundException)
            {
                return HandleNotFoundException(response, exception as EntityNotFoundException);
            }

            return HandleGenericException(response, exception);
        }

        private Task HandleNotFoundException(HttpResponse response, EntityNotFoundException exception)
        {
            response.StatusCode = (int)HttpStatusCode.NotFound;
            response.ContentType = "application/json";

            var message = new ErrorMessageDTO(exception.Message);
            return response.WriteAsync(message.Serialize());
        }

        private Task HandleGenericException(HttpResponse response, Exception exception)
        {
            response.StatusCode = (int)HttpStatusCode.InternalServerError;
            response.ContentType = "application/json";

            var message = new ExceptionMessageDTO(exception.Message, exception.StackTrace);
            return response.WriteAsync(message.Serialize());
        }
    }
}
