using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id= "819b1182-1e31-4d47-aa51-708962c68a3e",
                    Name=Roles.Admin,
                    NormalizedName= Roles.Admin.ToUpper(),
                },
                new IdentityRole
                {
                    Id= "819b1183-1e31-4d47-aa51-708962c68a3e",
                    Name= Roles.User,
                    NormalizedName = Roles.User.ToUpper(),
                }
                );
        }
    }
}