//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Sample Team Tools.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
 
    public partial class RoleConfiguration : BaseEntityTypeConfiguration<Role, long> 
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            RoleConfigure(builder);
            base.Configure(builder);
        }
    }

}




