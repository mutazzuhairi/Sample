using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public class BusinessAbsenceTypeConfiguration : BaseEntityTypeConfiguration<BusinessAbsenceType, long> 
    {
        public override void Configure(EntityTypeBuilder<BusinessAbsenceType> builder)
        {
            base.Configure(builder);
        }
    }

}




