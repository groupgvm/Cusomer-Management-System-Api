using CM.Contracts.System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
namespace CM.Middleware
{
    public class LoggingMiddleware : IMiddleware
    {
        private readonly ILoggerService _loggerService;

        public LoggingMiddleware(ILoggerService logger)
        {
            _loggerService = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _loggerService.LogInfo($"Incoming request path : {context.Request.Path}");

            await next(context);

            var responseHeaders = context.Response.Headers.Select(x => x.Value).Distinct().ToList();
            _loggerService.LogInfo($"Response headers : {string.Join(", ", responseHeaders)}");

        }
    }
}
