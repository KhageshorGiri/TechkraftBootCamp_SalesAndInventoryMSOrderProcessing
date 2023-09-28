using System.Diagnostics;

namespace OrderProcessing.Presentation.Middleware
{
    public class GlobalExceptionHabdelerMiddleware
    {
        private readonly RequestDelegate next;

        private ILogger<GlobalExceptionHabdelerMiddleware> logger;

        public GlobalExceptionHabdelerMiddleware(RequestDelegate _next,
            ILogger<GlobalExceptionHabdelerMiddleware> _logger)
        {
            this.next = _next;
            this.logger = _logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await next(httpContext);
            }
            catch(Exception ex)
            {
                logger.LogError(
                    ex,
                    "Could not process a request on machine {Machine}. Traceid: {TraceId}",
                    Environment.MachineName,
                    Activity.Current?.Id);

                await Results.Problem(
                    title: "We made a mistake but we are working on it!",
                    statusCode: StatusCodes.Status500InternalServerError,
                    extensions: new Dictionary<string, object?>
                    {
                        {"traceId", Activity.Current?.Id }
                    }
                    ).ExecuteAsync(httpContext);
            }
        }
    }
}
