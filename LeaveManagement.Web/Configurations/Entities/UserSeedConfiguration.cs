using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "819b1182-1e31-4d47-aa51-708962c68a4e",
                    Email = "thanhs1@admin.com",
                    NormalizedEmail = "THANHS1@ADMIN.COM",
                    UserName = "thanhs1@admin.com",
                    NormalizedUserName = "THANHS1@ADMIN.COM",
                    Firstname = "nguyen",
                    Lastname = "admin",
                    PasswordHash = hasher.HashPassword(null,"Abc@123456"),
                    EmailConfirmed = true,
                },
                new Employee
                {
                    Id = "819b1182-1e31-4d47-aa51-708962c68a5e",
                    Email = "thanhs2@user.com",
                    NormalizedEmail = "THANHS2@USER.COM",
                    UserName = "thanhs2@user.com",
                    NormalizedUserName = "THANHS2@USER.COM",
                    Firstname = "nguyen",
                    Lastname = "user",
                    PasswordHash = hasher.HashPassword(null,"Abc@123456"),
                    EmailConfirmed = true,
                });
        }
    }
}