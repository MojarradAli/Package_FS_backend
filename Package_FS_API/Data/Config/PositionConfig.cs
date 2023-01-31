using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Package_FS_API.Data.Config;

public class PositionConfig : IEntityTypeConfiguration<Position>
{
    public void Configure(EntityTypeBuilder<Position> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasMaxLength(256);

        builder.HasOne(x => x.Human).WithMany(x => x.Positions)
            .HasForeignKey(x => x.HumanId).OnDelete(DeleteBehavior.Cascade);
    }
}
