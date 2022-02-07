using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class UserRoleAutoMapperConfiguration : Profile
    {
        public UserRoleAutoMapperConfiguration()
        {
            CreateMap<UserRole, UserRoleDTO>().ReverseMap();
            CreateMap<UserRole, UserRoleView>().ReverseMap();
            CreateMap<UserRoleView, UserRoleDTO>().ReverseMap();
        }
    } 
}
