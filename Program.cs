using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RegisterInstanceService.Handle;
using RegisterInstanceService.Services;

var host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices(async (services) =>
    {
        services.AddScoped<IRun, Run>();

        services.AddScoped<SomeThingServiceFactory>();

        services.AddScoped<IBaseCoreService, ProductService>()
                .AddScoped<IProductService, ProductService>();

        services.AddScoped<IBaseCoreService, CategoryService>()
                .AddScoped<ICategoryService, CategoryService>();

        var serviceProvider = services.BuildServiceProvider();

        var runService = serviceProvider.GetRequiredService<IRun>();

        await runService.RunAsync();
    });

var app = host.Build();

await app.RunAsync();
