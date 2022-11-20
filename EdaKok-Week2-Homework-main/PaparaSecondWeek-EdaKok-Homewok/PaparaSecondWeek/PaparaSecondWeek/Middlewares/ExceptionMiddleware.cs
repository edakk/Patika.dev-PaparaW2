using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;

namespace PaparaSecondWeek.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
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
      
           await HandleExceptionAsync(httpContext, ex);
            }

        }

     private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            await context.Response.WriteAsync(context.Response.StatusCode + "Internal Server Error.");
        }  
    }   
        // Extension method used to add the middleware to the HTTP request pipeline.
        public static class ExceptionMiddlewareExtensions
        {
            public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
            {
                return builder.UseMiddleware<ExceptionMiddleware>();
            }
        }
    }

