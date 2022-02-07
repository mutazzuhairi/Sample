using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class RoleAutoMapperConfiguration : Profile
    {
        public RoleAutoMapperConfiguration()
        {
            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<Role, RoleView>().ReverseMap();
            CreateMap<RoleView, RoleDTO>().ReverseMap();
        }
    } 
}
