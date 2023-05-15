using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using TrevoirCar.Shared.Domain;

namespace TrevoirCar.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    Name = "Prius"
                },
                new Model
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    Name = "3 Series"
                }
                );
        }

    }
}
