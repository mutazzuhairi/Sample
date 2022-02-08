using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class AbsenceConfiguration : BaseEntityTypeConfiguration<Absence, long> 
    {
        private void AbsenceConfigure(EntityTypeBuilder<Absence> builder)
        {
            builder.HasCheckConstraint("constraint_status", "'Status' = 'New' or 'Status' = 'Approved' or 'Status' = 'Rejected'");
        }
    }

}




