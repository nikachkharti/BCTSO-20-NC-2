using System.Net;
using University.Service.Exceptions;

namespace University.API.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExcpetionAsync(context, ex);
            }
        }

        private Task HandleExcpetionAsync(HttpContext context, Exception exception)
        {
            ApiResponse response = new();

            switch (exception)
            {
                case ArgumentNullException:
                case ArgumentException:
                    response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                    response.Message = exception.Message;
                    response.IsSuccess = false;
                    response.Result = null;
                    break;
                case NotFoundException:
                    response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                    response.Message = exception.Message;
                    response.IsSuccess = false;
                    response.Result = null;
                    break;
                case AmbigousNameException:
                    response.StatusCode = Convert.ToInt32(HttpStatusCode.Conflict);
                    response.Message = exception.Message;
                    response.IsSuccess = false;
                    response.Result = null;
                    break;
                default:
                    response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                    response.Message = exception.Message;
                    response.IsSuccess = false;
                    response.Result = null;
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = response.StatusCode;

            return context.Response.WriteAsJsonAsync(response);
        }
    }
}
