using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.BLUtilities.Interfaces;

namespace Sample.BLLayer.QueryServices.Interfaces
{
 
    public interface IUserLoginQueryService : IQueryService<UserLoginDTO, UserLoginView>
    {


    }

}