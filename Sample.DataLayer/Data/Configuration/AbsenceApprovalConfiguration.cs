using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class AbsenceApprovalConfiguration : BaseEntityTypeConfiguration<AbsenceApproval, long> 
    {
        private void AbsenceApprovalConfigure(EntityTypeBuilder<AbsenceApproval> builder)
        {
            
        }
    }

}




