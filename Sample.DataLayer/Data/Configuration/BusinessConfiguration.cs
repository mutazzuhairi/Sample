using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class BusinessConfiguration : BaseEntityTypeConfiguration<Business, long> 
    {
        private void BusinessConfigure(EntityTypeBuilder<Business> builder)
        {
            
        }
    }

}




