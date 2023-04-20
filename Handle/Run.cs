using Microsoft.Extensions.Logging;
using RegisterInstanceService.Services;

namespace RegisterInstanceService.Handle;

public interface IRun
{
    Task RunAsync();
}

public class Run : IRun
{
    private readonly SomeThingServiceFactory _serviceFactory;
    private readonly ILogger _logger;

    public Run(SomeThingServiceFactory serviceFactory, ILogger<Run> logger)
    {
        _serviceFactory = serviceFactory;
        _logger = logger;
    }

    public async Task RunAsync()
    {
        var product = await _serviceFactory.GetGetCoreService("1").ProcessAsync(new());
        _logger.LogInformation("Result {product}", product);
    }
}
