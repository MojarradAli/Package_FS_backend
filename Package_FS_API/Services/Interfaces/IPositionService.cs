namespace Package_FS_API.Services;

public interface IPositionService
{
    Task<IEnumerable<CountInstanceDto>> CountInstancesAsync();

    Task<IEnumerable<PositionInstanceDto>> PositionInstancesAsync();
}
