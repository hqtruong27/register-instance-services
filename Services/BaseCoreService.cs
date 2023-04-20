using Microsoft.Extensions.DependencyInjection;
using RegisterInstanceService.Models;

namespace RegisterInstanceService.Services;

public interface IBaseCoreService
{
    abstract Task<IResponse> ProcessAsync(Request request);
}

public class SomeThingServiceFactory
{
    private readonly IServiceProvider _serviceProvider;

    public SomeThingServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IBaseCoreService GetGetCoreService(string code)
    {
        return code switch
        {
            "1" => _serviceProvider.GetRequiredService<IProductService>(),
            "2" => _serviceProvider.GetRequiredService<ICategoryService>(),
            _ => throw new NotImplementedException(),
        };
    }
}
