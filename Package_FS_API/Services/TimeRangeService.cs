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
        long min = 0;
        long max = 0;

        var hasItem = await _dbContext.Positions.AnyAsync();
        if (hasItem)
        {
            min = await _dbContext.Positions.MinAsync(x => x.UnixTime);
            max = await _dbContext.Positions.MaxAsync(x => x.UnixTime);
        }
        return TimeRangeDto.Create(min, max);
    }
}
