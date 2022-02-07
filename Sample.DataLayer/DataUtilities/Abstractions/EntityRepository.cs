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
        protected DbSet<TEntity> _entity;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public EntityRepository(MainContext context, Lazy<ISystemServiceProvider> systemServiceProvider)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
            _systemServiceProvider = systemServiceProvider;
        }
        public virtual IQueryable<TEntity> AsQueryable()
        {
            return   _context.Set<TEntity>();
        }
        public virtual async Task<TEntity> FindAsync(params object[] keyValues)
        {
            return await _entity.FindAsync(keyValues);
        }
        public virtual void AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            entity.GetType().GetProperty(nameof(BaseEntity<long>.CreatedDate)).SetValue(entity, DateTimeOffset.UtcNow);
            entity.GetType().GetProperty(nameof(BaseEntity<long>.UpdatedDate)).SetValue(entity, DateTimeOffset.UtcNow);
            entity.GetType().GetProperty(nameof(BaseEntity<long>.CreatedBy)).SetValue(entity, _systemServiceProvider.Value.GetCurrentUserId());
            entity.GetType().GetProperty(nameof(BaseEntity<long>.UpdatedBy)).SetValue(entity, _systemServiceProvider.Value.GetCurrentUserId());
            _entity.AddAsync(entity);
        }
        public virtual void Remove(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            _entity.Remove(entity);
        }
        public virtual void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }
            var currentUserId = _systemServiceProvider.Value.GetCurrentUserId()?.ToString() ?? "System";
            entity.GetType().GetProperty(nameof(BaseEntity<long>.UpdatedDate)).SetValue(entity, DateTimeOffset.UtcNow);
            entity.GetType().GetProperty(nameof(BaseEntity<long>.UpdatedBy)).SetValue(entity, currentUserId);
            _entity.Update(entity);
        }
        public async Task<int> CountAsync()
        {
            return await _entity.CountAsync();
        }
        public virtual async Task<int> SaveChangesAsync()
        {
             return await _context.SaveChangesAsync();
        }

    }
}
