using RegisterInstanceService.Models;

namespace RegisterInstanceService.Services;

public interface IProductService : IBaseCoreService
{

}

public class ProductService : IProductService
{
    public async Task<IResponse> ProcessAsync(Request request)
    {
        var result = new Response { Code = "1", Description = "Some thing description" };

        return await Task.FromResult(result);
    }
}
