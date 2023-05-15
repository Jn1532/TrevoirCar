using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using TrevoirCar.Shared.Domain;

namespace TrevoirCar.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                new Make
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    Name = "BMW"
                },
                new Make
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    Name = "Toyota"
                }
                );
        }

    }
}
