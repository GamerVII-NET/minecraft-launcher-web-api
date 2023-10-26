namespace GamerVII.LauncherServer.Core.Extensions;

public static class RoutingExtensions
{
    public static WebApplication RegisterRoutes(this WebApplication app)
    {
        app.MapGet("/", () => Results.Ok($"GamerVII.LauncherServer, swagger: http://localhost:5000/swagger/index.html"));

        return app;
    }
}
