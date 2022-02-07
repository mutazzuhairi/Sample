using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class UserLoginAutoMapperConfiguration : Profile
    {
        public UserLoginAutoMapperConfiguration()
        {
            CreateMap<UserLogin, UserLoginDTO>().ReverseMap();
            CreateMap<UserLogin, UserLoginView>().ReverseMap();
            CreateMap<UserLoginView, UserLoginDTO>().ReverseMap();
        }
    } 
}
