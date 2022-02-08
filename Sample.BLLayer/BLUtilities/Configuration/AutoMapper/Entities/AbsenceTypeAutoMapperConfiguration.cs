using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class AbsenceTypeAutoMapperConfiguration : Profile
    {
        public AbsenceTypeAutoMapperConfiguration()
        {
            CreateMap<AbsenceType, AbsenceTypeDTO>().ReverseMap();
            CreateMap<AbsenceType, AbsenceTypeView>().ReverseMap();
            CreateMap<AbsenceTypeView, AbsenceTypeDTO>().ReverseMap();
        }
    } 
}
