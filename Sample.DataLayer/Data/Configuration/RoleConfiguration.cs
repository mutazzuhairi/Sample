using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class RoleConfiguration : BaseEntityTypeConfiguration<Role, long> 
    {
        private void RoleConfigure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(SeedData());
        }

        private Role[] SeedData()
        {
            Role[] roles = new Role[1];
            roles[0] = new Role
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                SearchField = "System"
            };
            return roles;
        }
    }

}




