using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Data.Configurations
{
    internal class CoatchConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            // Configuration for Coach entity can be added here
            builder.HasData(
                new Coach { Id = 1, Name = "John Doe", CreatedDate = new DateTime(2025, 01, 01) },
                new Coach { Id = 2, Name = "Jane Smith", CreatedDate = new DateTime(2025, 01, 01) },
                new Coach { Id = 3, Name = "Mike Johnson", CreatedDate = new DateTime(2025, 01, 01) }
            );
        }
    }
}
