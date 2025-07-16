using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Data.Configurations
{
    internal class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.HasQueryFilter(l => !l.IsDeleted);
            // Configuration for League entity can be added here
            builder.HasData(
                new League { Id = 1, Name = "Premier League", CreatedDate = new DateTime(2025, 01, 01) },
                new League { Id = 2, Name = "Championship", CreatedDate = new DateTime(2025, 01, 01) },
                new League { Id = 3, Name = "League One", CreatedDate = new DateTime(2025, 01, 01) }
            );
        }
    }
}
