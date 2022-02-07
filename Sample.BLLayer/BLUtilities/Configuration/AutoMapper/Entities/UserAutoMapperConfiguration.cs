using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class UserAutoMapperConfiguration : Profile
    {
        public UserAutoMapperConfiguration()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserView>().ReverseMap();
            CreateMap<UserView, UserDTO>().ReverseMap();
        }
    }
}
