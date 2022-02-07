using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.DataLayer.DataUtilities.Interfaces;
using Sample.DataLayer.DataUtilities.SystemConstants;
using Sample.DataLayer.DataUtilities.Extensions;

namespace Sample.DataLayer.DataUtilities.Abstractions
{
    public class BaseEntityTypeConfiguration<TEntity, Tkey> : IEntityTypeConfiguration<TEntity>
       where TEntity : class, IBaseEntity<Tkey>

    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(typeof(TEntity).Name.Pluralize());
            builder.Property(e => e.CreatedDate).HasDefaultValueSql(SampleConstatnts.SqlServerDefaultValues.CURRENT_DATE_TIME_OFFSET);
            builder.Property(e => e.UpdatedDate).HasDefaultValueSql(SampleConstatnts.SqlServerDefaultValues.CURRENT_DATE_TIME_OFFSET);
            builder.Property(e => e.CreatedBy).HasDefaultValueSql(SampleConstatnts.SqlServerDefaultValues.SYSTEM);
            builder.Property(e => e.UpdatedBy).HasDefaultValueSql(SampleConstatnts.SqlServerDefaultValues.SYSTEM);
            builder.Property(e => e.Void).HasDefaultValueSql(SampleConstatnts.SqlServerDefaultValues.BOOLEAN_FALSE);
            builder.Property(e => e.Version).IsRowVersion().IsConcurrencyToken();
            builder.HasIndex(b => b.SearchField).HasFilter($"[{nameof(IBaseEntity<long>.SearchField)}] IS NOT NULL");

        }
    }
}
