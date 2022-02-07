using System.Threading.Tasks;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.Extends.ExtendModels;

namespace Sample.BLLayer.Extends.ExtendServices.Interfaces
{
    public interface IAuthService
    {
        public Task<AuthResponseModel> Login(UserAuthModel userAuthModel);
 
    }
}
