using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class UserTokenConfiguration : BaseEntityTypeConfiguration<UserToken, long> 
    {
        private void UserTokenConfigure(EntityTypeBuilder<UserToken> builder)
        {
            
        }
    }

}




