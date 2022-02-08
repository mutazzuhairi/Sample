using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public class BusinessConfiguration : BaseEntityTypeConfiguration<Business, long> 
    {
        public override void Configure(EntityTypeBuilder<Business> builder)
        {
            base.Configure(builder);
        }
    }

}




