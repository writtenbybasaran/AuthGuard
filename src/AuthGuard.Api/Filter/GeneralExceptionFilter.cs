using System;
using System.Net;
using System.Security.Authentication;
using AuthGuard.Common.CustomExceptions;
using AuthGuard.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace AuthGuard.Api.Filter
{
    public class GeneralExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<GeneralExceptionFilter> _logger;

        public GeneralExceptionFilter(ILogger<GeneralExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            var basicErrorResponse = new BasicErrorHttpResponse();

            string traceId = context.HttpContext.TraceIdentifier;

            Exception ex = context.Exception;
            HttpStatusCode httpStatusCode;
            basicErrorResponse.Message = context.Exception.Message;

            if (ex is NotFoundException)
            {
                _logger.LogWarning(ex, $"TraceId: {traceId} - {basicErrorResponse.Message}", null);
                httpStatusCode = HttpStatusCode.NotFound;
            }
            else
            {
                _logger.LogError(ex, $"TraceId: {traceId} - {basicErrorResponse.Message}", null);
                httpStatusCode = HttpStatusCode.InternalServerError;
                basicErrorResponse.Message = "Bilinmeyen bir hata oluştu.";
            }

            context.Result = new ObjectResult(basicErrorResponse)
            {
                StatusCode = (int)httpStatusCode
            };
        }
    }
}
