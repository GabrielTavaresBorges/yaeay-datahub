using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YaeaY.DataHub.Domain.Entities.Brazil.CBO.AggregateRoots;

namespace YaeaY.DataHub.Infrastructure.Data.Mappings.Brazil.CBO;

public sealed class CboMainSubgroupMap : IEntityTypeConfiguration<CboMainSubgroup>
{
    public void Configure(EntityTypeBuilder<CboMainSubgroup> builder)
    {
        builder.ToTable("CboMainSubgroups");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Code)
            .IsRequired()
            .HasMaxLength(2);

        builder.Property(x => x.GreatGroupId)
            .IsRequired();

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.CreatedAt)
            .IsRequired();
    }
}
