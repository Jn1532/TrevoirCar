using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TrevoirCar.Shared.Domain;

namespace TrevoirCar.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                     Id = "990f4071-6b78-476f-bef2-c7665515e6f5",
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = "990f4071-6b78-476f-bef2-c7665515e6f4",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
                );
        }
    }
}
