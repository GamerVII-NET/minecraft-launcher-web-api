using GamerVII.LauncherServer.Core.Extensions;

WebApplication.CreateBuilder(args)
    .RegisterServices()
    .Build()
    .RegisterApplication()
    .Run();
