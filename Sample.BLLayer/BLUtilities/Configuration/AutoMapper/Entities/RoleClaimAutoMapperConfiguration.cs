using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class RoleClaimAutoMapperConfiguration : Profile
    {
        public RoleClaimAutoMapperConfiguration()
        {
            CreateMap<RoleClaim, RoleClaimDTO>().ReverseMap();
            CreateMap<RoleClaim, RoleClaimView>().ReverseMap();
            CreateMap<RoleClaimView, RoleClaimDTO>().ReverseMap();
        }
    } 
}
