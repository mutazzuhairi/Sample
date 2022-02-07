using Sample.BLLayer.BLUtilities.Interfaces;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities;
using System.Threading.Tasks;

namespace Sample.BLLayer.QueryServices.Interfaces
{
    public interface IUserQueryService : IQueryService<UserDTO, UserView>
    {
        public Task<User> FindByEmailAsync(string email);
        public Task<bool> CheckPasswordAsync(User user, string password);
        public Task<UserDTO> FindUserDTOByEmailAsync(string email);
        public bool IsUserNameAlreadyExist(string userName, long id);
    }

}
