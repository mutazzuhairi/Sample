using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Abstractions;

namespace Sample.DataLayer.Data.Configuration
{
    public partial class UserConfiguration : BaseEntityTypeConfiguration<User, long>
    {
        public void UserConfigure(EntityTypeBuilder<User> builder)
        {
            builder.Property(s=>s.Email).HasMaxLength(100).IsRequired();
            builder.Property(s => s.UserName).HasMaxLength(200).IsRequired();
            builder.Property(s => s.PasswordHash).IsRequired();
            base.Configure(builder);
        }
    }
}
