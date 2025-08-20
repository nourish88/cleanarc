using CleanArchitecture.Infrastructure.Persistence.Contexts;
using CleanArchitecture.Infrastructure.ServiceRegistrations;


try
{

    var builder = WebApplication.CreateBuilder(args);
    var config = new WebApiStartUpConfig(builder, Constants.BaseConnectionStringName, DbContextProjectName: "Infrastructure");

    var options = CleanArcProgramHelper.RegisterServices<BaseDbContext>(config);
    // builder.Services.RegisterInfrastructureServices(builder.Configuration);

    var app = builder.Build();


    // app.UseInfrastructure();
    app.UseCors();
    CleanArcProgramHelper.UseJugaMiddlewares(app, config, options);

    await app.RunAsync().ConfigureAwait(false);
}
catch (Exception ex)
{
    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    Log.Information("Shut down complete");
    await Log.CloseAndFlushAsync().ConfigureAwait(false);
}