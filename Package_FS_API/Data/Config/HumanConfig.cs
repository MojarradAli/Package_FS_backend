using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Package_FS_API.Data.Config;

public class HumanConfig : IEntityTypeConfiguration<Human>
{
    public void Configure(EntityTypeBuilder<Human> builder)
    {
        builder.HasKey(x => x.Id);
    }
}

