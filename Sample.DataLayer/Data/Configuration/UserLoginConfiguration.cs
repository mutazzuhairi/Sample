using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class UserLoginConfiguration : BaseEntityTypeConfiguration<UserLogin, long> 
    {
        private void UserLoginConfigure(EntityTypeBuilder<UserLogin> builder)
        {
            
        }
    }

}




