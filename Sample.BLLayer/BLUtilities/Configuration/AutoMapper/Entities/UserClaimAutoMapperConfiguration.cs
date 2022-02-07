using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class UserClaimAutoMapperConfiguration : Profile
    {
        public UserClaimAutoMapperConfiguration()
        {
            CreateMap<UserClaim, UserClaimDTO>().ReverseMap();
            CreateMap<UserClaim, UserClaimView>().ReverseMap();
            CreateMap<UserClaimView, UserClaimDTO>().ReverseMap();
        }
    } 
}
