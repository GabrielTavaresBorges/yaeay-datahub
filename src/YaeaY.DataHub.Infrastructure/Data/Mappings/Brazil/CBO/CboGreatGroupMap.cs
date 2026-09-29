using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YaeaY.DataHub.Domain.Entities.Brazil.CBO.AggregateRoots;

namespace YaeaY.DataHub.Infrastructure.Data.Mappings.Brazil.CBO;

public sealed class CboGreatGroupMap : IEntityTypeConfiguration<CboGreatGroup>
{
    public void Configure(EntityTypeBuilder<CboGreatGroup> builder)
    {
        builder.ToTable("CboGreatGroups");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Code)
            .IsRequired()
            .HasMaxLength(1);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(x => x.CompetenceLevel)
            .IsRequired(false);

        builder.Property(x => x.CreatedAt)
            .IsRequired();
    }
}
