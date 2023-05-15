using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TrevoirCar.Server.Models;
using TrevoirCar.Shared.Domain;

namespace TrevoirCar.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
       
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                new ApplicationUser
                {
                 Id = "5a6df2c4-69ac-4b7a-af58-951a1e46b21d",
                 Email = "admin@localhost.com",
                 NormalizedEmail = "ADMIN@LOCALHOST.COM",
                 FirstName = "Admin",
                 LastName = "User",
                 UserName = "Admin",
                 NormalizedUserName ="ADMIN",   
                 PasswordHash = hasher.HashPassword(null,"P@ssword1")
                 
                }
                );
        }
    }
}
