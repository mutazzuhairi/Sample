using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public class AbsenceConfiguration : BaseEntityTypeConfiguration<Absence, long> 
    {
        public override void Configure(EntityTypeBuilder<Absence> builder)
        {
            builder.HasCheckConstraint("constraint_status", "'Status' = 'New' or 'Status' = 'Approved' or 'Status' = 'Rejected'");
            builder.Property(e => e.Status).HasDefaultValueSql("'New'");
            base.Configure(builder);
        }
    }

}




