using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class UserTokenAutoMapperConfiguration : Profile
    {
        public UserTokenAutoMapperConfiguration()
        {
            CreateMap<UserToken, UserTokenDTO>().ReverseMap();
            CreateMap<UserToken, UserTokenView>().ReverseMap();
            CreateMap<UserTokenView, UserTokenDTO>().ReverseMap();
        }
    } 
}
