using Package_FS_API.Data.Config;

namespace Package_FS_API.Data;

public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> options)
        : base(options)
    {
    }

    public DbSet<Human> Humen { get; set; }

    public DbSet<Position> Positions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new HumanConfig());
        modelBuilder.ApplyConfiguration(new PositionConfig());
    }
}
