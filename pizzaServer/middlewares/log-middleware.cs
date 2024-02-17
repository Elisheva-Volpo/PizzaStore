

using bigPizzaServer.Interface;
using bigPizzaServer.pizzaServer.extensions;


namespace bigPizzaServer.pizzaServer.middlewares;

public class LogMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IFile<string> _file;

    public LogMiddleware(RequestDelegate next, IFile<string> file)
    {
        this._next = next;
        this._file = file;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        DateTime time = DateTime.Now;
        string method = context.Request.Method;
        string path = context.Request.Path;
        string protocol = context.Request.Protocol;
        if (path != "/index.html" && path != "/favicon.ico")
        {
            string xr = "the request:  date time: " + time + " method: " + method + " path: " + path + " protocol: " + protocol;
            _file.Write(xr, Path.Combine(Environment.CurrentDirectory, "file", "log"));
        }
        await _next(context);
        DateTime after = DateTime.Now;
        int status = context.Response.StatusCode;
        if (path != "/index.html" && path != "/favicon.ico")
        {
            string xs = "the response:  date time: " + after + " status code: " + status;
            _file.Write(xs, Path.Combine(Environment.CurrentDirectory, "File", "log.txt"));
        }
    }
}