using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public static class SeedDataGenerator
    {
        public static void GenerateSeedUser(ModelBuilder modelBuilder)
        {

            const string userId = "ac6d6757-a825-4dda-9b5c-c37c00785f26";
            const string roleId = "355f0449-cb69-47a5-92d0-d0c3f385beab";

            var newUser = new ApplicationUser()
            {
                Id = userId,
                UserName = "Admin",
                NormalizedUserName = "admin".ToUpper(),
                Email = "Sahand.Salmani@gmail.com",
                NormalizedEmail = "sahand.salmani@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "0507913221",
                TwoFactorEnabled = true,
                ConcurrencyStamp = userId,
                PhoneNumberConfirmed = true
            };
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            newUser.PasswordHash = passwordHasher.HashPassword(newUser, "Sahand235");


            var role = new ApplicationRole()
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin".ToUpper(),
                ConcurrencyStamp = roleId
            };

            var userRole = new ApplicationUserRole()
            {
                RoleId = role.Id,
                UserId = newUser.Id,
            };


            modelBuilder.Entity<ApplicationUser>().HasData(newUser);
            modelBuilder.Entity<ApplicationRole>().HasData(role);
            modelBuilder.Entity<ApplicationUserRole>().HasData(userRole);


        }
    }
}
