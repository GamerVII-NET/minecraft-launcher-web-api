namespace GamerVII.LauncherServer.Core.Extensions;

public static class ApplicationExtensions
{

    public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder;
    }

    public static WebApplication RegisterApplication(this WebApplication app)
    {

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();
        app.RegisterRoutes();
        // app.UseHttpsRedirection();

        return app;
    }

}
