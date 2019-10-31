using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HelloDIProject
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");

            return next(context);
        }

        public ConsoleLoggerMiddleware(Printer printer)
        {
            printer.Log("Hi. I am lost.");
        }
    }
}
