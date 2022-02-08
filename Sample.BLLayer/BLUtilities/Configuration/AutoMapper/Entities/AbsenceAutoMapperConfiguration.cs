using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class AbsenceAutoMapperConfiguration : Profile
    {
        public AbsenceAutoMapperConfiguration()
        {
            CreateMap<Absence, AbsenceDTO>().ReverseMap();
            CreateMap<Absence, AbsenceView>().ReverseMap();
            CreateMap<AbsenceView, AbsenceDTO>().ReverseMap();
        }
    } 
}
