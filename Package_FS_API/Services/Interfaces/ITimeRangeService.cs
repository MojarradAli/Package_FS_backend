namespace Package_FS_API.Services;

public interface ITimeRangeService
{
    Task<TimeRangeDto> GetAsync();
}
