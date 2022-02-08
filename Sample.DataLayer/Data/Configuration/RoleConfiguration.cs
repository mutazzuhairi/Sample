using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public class RoleConfiguration : BaseEntityTypeConfiguration<Role, long> 
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
        }
    }

}




