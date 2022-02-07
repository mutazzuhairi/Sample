using Sample.DataLayer.Data.Models.Entities;
using Sample.DataLayer.DataUtilities.Interfaces;
using System.Threading.Tasks;

namespace Sample.DataLayer.Data.Repositries.Interfaces
{
    public interface IUserRepositry : IRepository<User>
    {
        public Task<User> FindByEmailAsync(string email);
        public Task<bool> CheckPasswordAsync(User user, string password);
        public Task SetLockoutEnabledAsync(User entity, bool enabled);
        public Task AddToRoleAsync(User entity, string role);
        public Task CreateAsync(User entity, string password);
        public Task UpdateAsync(User entity);
        public Task UpdatePasswordAsync(User entity, string currentPassword, string newPassword);
        public Task RemoveFromRoleAsync(User entity, string role);
    }

}
 
