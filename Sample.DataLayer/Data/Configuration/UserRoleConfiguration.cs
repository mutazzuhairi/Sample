using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class UserRoleConfiguration : BaseEntityTypeConfiguration<UserRole, long> 
    {
        private void UserRoleConfigure(EntityTypeBuilder<UserRole> builder)
        {
            
        }
    }

}




