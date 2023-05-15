using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TrevoirCar.Server.Models;
using TrevoirCar.Shared.Domain;

namespace TrevoirCar.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {


            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "990f4071-6b78-476f-bef2-c7665515e6f4",
                    UserId = "5a6df2c4-69ac-4b7a-af58-951a1e46b21d"

                }
                ); ;
        }
    }
}
