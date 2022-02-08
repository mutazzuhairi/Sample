using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities; 

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities
{
    public class AbsenceApprovalAutoMapperConfiguration : Profile
    {
        public AbsenceApprovalAutoMapperConfiguration()
        {
            CreateMap<AbsenceApproval, AbsenceApprovalDTO>().ReverseMap();
            CreateMap<AbsenceApproval, AbsenceApprovalView>().ReverseMap();
            CreateMap<AbsenceApprovalView, AbsenceApprovalDTO>().ReverseMap();
        }
    } 
}
