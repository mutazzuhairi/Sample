using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sample.DataLayer.DataUtilities.DBContext;
using Sample.DataLayer.DataUtilities.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.DataLayer.DataUtilities.Abstractions
{
    public abstract class EntityRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly MainContext _context;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public EntityRepository(MainContext context, Lazy<ISystemServiceProvider> systemServiceProvider)
        {
            _context = context;
            _systemServiceProvider = systemServiceProvider;
        }
        public virtual IQueryable<TEntity> GetAll()
        {
            return   _context.Set<TEntity>();
        }
        public virtual async Task<TEntity> FindAsync(params object[] keyValues)
        {
            return await _context.Set<TEntity>().FindAsync(keyValues);
        }
        public virtual void Add(TEntity entity)
        {
            _context.Set<TEntity>().AddAsync(entity);
            entity.GetType().GetProperty(nameof(BaseEntity<long>.CreatedDate)).SetValue(entity, DateTimeOffset.UtcNow);
            entity.GetType().GetProperty(nameof(BaseEntity<long>.UpdatedDate)).SetValue(entity, DateTimeOffset.UtcNow);
            entity.GetType().GetProperty(nameof(BaseEntity<long>.CreatedBy)).SetValue(entity, _systemServiceProvider.Value.GetCurrentUserId());
            entity.GetType().GetProperty(nameof(BaseEntity<long>.UpdatedBy)).SetValue(entity, _systemServiceProvider.Value.GetCurrentUserId());
        }
        public virtual void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
        }
        public virtual void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            entity.GetType().GetProperty(nameof(BaseEntity<long>.UpdatedDate)).SetValue(entity, DateTimeOffset.UtcNow);
            entity.GetType().GetProperty(nameof(BaseEntity<long>.UpdatedBy)).SetValue(entity, _systemServiceProvider.Value.GetCurrentUserId());
        }
        public virtual async Task<int> SubmitChanges()
        {
             return await _context.SaveChangesAsync();
        }

    }
}
