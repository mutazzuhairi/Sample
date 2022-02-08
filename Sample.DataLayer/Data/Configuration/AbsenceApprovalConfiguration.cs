using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public class AbsenceApprovalConfiguration : BaseEntityTypeConfiguration<AbsenceApproval, long> 
    {
        public override void Configure(EntityTypeBuilder<AbsenceApproval> builder)
        {
            base.Configure(builder);
        }
    }

}




