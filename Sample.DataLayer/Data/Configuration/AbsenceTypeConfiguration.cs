using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class AbsenceTypeConfiguration : BaseEntityTypeConfiguration<AbsenceType, long> 
    {
        private void AbsenceTypeConfigure(EntityTypeBuilder<AbsenceType> builder)
        {
            builder.HasCheckConstraint("constraint_name", "'Name' = 'Sick Leave' or 'Name' = 'Paid Time Off'");
        }
    }

}




