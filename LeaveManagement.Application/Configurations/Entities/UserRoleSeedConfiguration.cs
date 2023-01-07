using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Application.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string> { 
                RoleId= "819b1182-1e31-4d47-aa51-708962c68a3e",
                UserId= "819b1182-1e31-4d47-aa51-708962c68a4e",
                },
                new IdentityUserRole<string> { 
                RoleId= "819b1183-1e31-4d47-aa51-708962c68a3e",
                UserId= "819b1182-1e31-4d47-aa51-708962c68a5e",
                }
                );
        }
    }
}