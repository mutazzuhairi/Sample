using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class BusinessAutoMapperConfiguration : Profile
    {
        public BusinessAutoMapperConfiguration()
        {
            CreateMap<Business, BusinessDTO>().ReverseMap();
            CreateMap<Business, BusinessView>().ReverseMap();
            CreateMap<BusinessView, BusinessDTO>().ReverseMap();
        }
    } 
}
