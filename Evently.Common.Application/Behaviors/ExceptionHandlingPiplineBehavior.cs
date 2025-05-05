using System;
using System.Threading;
using System.Threading.Tasks;
using Evently.Common.Application.Exceptions;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Evently.Common.Application.Behaviors;

internal sealed class ExceptionHandlingPiplineBehavior<TRequest, TResponse>
    (ILogger<ExceptionHandlingPiplineBehavior<TRequest, TResponse>> logger)
    : IPipelineBehavior<TRequest, TResponse> where TRequest : class
{
    public async Task<TResponse> Handle
        (
            TRequest request, 
            RequestHandlerDelegate<TResponse> next, 
            CancellationToken cancellationToken
            )
    {
        try
        {
            return await next();
        }
        catch (Exception exception)
        {
            logger.LogError(exception, "Unhandled exception for {RequestName}",typeof(TRequest).Name);
            throw new EventlyException(typeof(TRequest).Name,innerException:exception);
        }
    }
}