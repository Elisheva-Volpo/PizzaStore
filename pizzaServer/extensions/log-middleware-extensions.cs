using bigPizzaServer.pizzaServer.middlewares;
namespace bigPizzaServer.pizzaServer.extensions;

public static class LogMiddlewareExtentions{
    public static IApplicationBuilder UseLogMiddlewaweExtentions(
        this IApplicationBuilder builder
    ){
        return builder.UseMiddleware<LogMiddleware>();
    }
}