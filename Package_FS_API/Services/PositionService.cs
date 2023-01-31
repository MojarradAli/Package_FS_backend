using Package_FS_API.Data;

namespace Package_FS_API.Services;

public class PositionService : IPositionService
{
    private readonly MainDbContext _dbContext;

    public PositionService(MainDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<CountInstanceDto>> CountInstanceAsync()
    {
        var query = _dbContext.Instances.GroupBy(x => x.UnixTime)
            .Where(x => x.Any())
            .Select(x => new CountInstanceDto
            {
                TimeStamp = x.Key,
                X = x.First().X
            });

        return await query.ToListAsync();
    }
}
