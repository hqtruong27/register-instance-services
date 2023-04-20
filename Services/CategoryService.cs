using RegisterInstanceService.Models;

namespace RegisterInstanceService.Services;
public interface ICategoryService : IBaseCoreService
{
}
public class CategoryService : ICategoryService
{
    public async Task<IResponse> ProcessAsync(Request request)
    {
        var result = new Response { Code = "2", Description = "Some thing description 2" };

        return await Task.FromResult(result);
    }
}
