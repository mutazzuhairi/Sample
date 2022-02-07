using System.Linq;
using System.Threading.Tasks;

namespace Sample.DataLayer.DataUtilities.Interfaces
{
    public interface IRepository <TEntity>
    {
        void AddAsync(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        IQueryable<TEntity> AsQueryable();
        Task<TEntity> FindAsync(params object[] keyValues);
        Task<int> CountAsync();
        Task<int> SaveChangesAsync();
    }
}
