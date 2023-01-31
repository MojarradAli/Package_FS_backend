namespace Package_FS_API.Services;

public class PositionService : IPositionService
{
    private readonly MainDbContext _dbContext;

    public PositionService(MainDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<CountInstanceDto>> CountInstancesAsync()
    {
        var query = _dbContext.Positions.GroupBy(x => x.UnixTime)
            .Where(x => x.Any())
            .Select(x => new CountInstanceDto
            {
                TimeStamp = x.Key,
                X = x.First().X
            });

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<PositionInstanceDto>> PositionInstancesAsync()
    {
        var query = _dbContext.Positions.GroupBy(x => x.UnixTime)
            .Where(x => x.Any())
            .Select(x => new PositionInstanceDto
            {
                TimeStamp = x.Key,
                Instances = x.Select(x => new PositionInstance
                {
                    HumanId = x.HumanId,
                    X = x.X
                })
            });

        return await query.ToListAsync();
    }
}
