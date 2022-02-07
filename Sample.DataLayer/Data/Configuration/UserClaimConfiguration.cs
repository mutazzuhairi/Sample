using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class UserClaimConfiguration : BaseEntityTypeConfiguration<UserClaim, int> 
    {
        private void UserClaimConfigure(EntityTypeBuilder<UserClaim> builder)
        {
            
        }
    }

}




