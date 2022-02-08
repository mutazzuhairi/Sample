using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public class AbsenceTypeConfiguration : BaseEntityTypeConfiguration<AbsenceType, long> 
    {
        public override void Configure(EntityTypeBuilder<AbsenceType> builder)
        {
            builder.HasCheckConstraint("constraint_name", "'Name' = 'Sick Leave' or 'Name' = 'Paid Time Off'");
            base.Configure(builder);
        }
    }

}




