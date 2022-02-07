using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class RoleClaimConfiguration : BaseEntityTypeConfiguration<RoleClaim, int> 
    {
        private void RoleClaimConfigure(EntityTypeBuilder<RoleClaim> builder)
        {
            
        }
    }

}




