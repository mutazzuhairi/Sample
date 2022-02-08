using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class BusinessAbsenceTypeConfiguration : BaseEntityTypeConfiguration<BusinessAbsenceType, long> 
    {
        private void BusinessAbsenceTypeConfigure(EntityTypeBuilder<BusinessAbsenceType> builder)
        {
            
        }
    }

}




