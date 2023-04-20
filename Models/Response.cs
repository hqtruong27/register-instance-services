namespace RegisterInstanceService.Models;

public interface IResponse
{
    abstract string Code { get; set; }
    abstract string Description { get; set; }
}

public record Response : IResponse
{
    public string Code { get; set; } = default!;
    public string Description { get; set; } = default!;
}
