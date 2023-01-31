using Package_FS_API.Data;

namespace Package_FS_API.Services;

public class TimeRangeService : ITimeRangeService
{
    private readonly MainDbContext _dbContext;

    public TimeRangeService(MainDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TimeRangeDto> GetAsync()
    {
        var min = await _dbContext.Instances.MinAsync(x => x.UnixTime);
        var max = await _dbContext.Instances.MaxAsync(x => x.UnixTime);

        return TimeRangeDto.Create(min, max);
    }
}
