using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class BusinessAbsenceTypeAutoMapperConfiguration : Profile
    {
        public BusinessAbsenceTypeAutoMapperConfiguration()
        {
            CreateMap<BusinessAbsenceType, BusinessAbsenceTypeDTO>().ReverseMap();
            CreateMap<BusinessAbsenceType, BusinessAbsenceTypeView>().ReverseMap();
            CreateMap<BusinessAbsenceTypeView, BusinessAbsenceTypeDTO>().ReverseMap();
        }
    } 
}
