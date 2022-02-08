using Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.BLLayer.BLUtilities.Configuration.AutoMapper.Configuration.Generated
{
 
    public static class AutoMapperConfigurationGenerated
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {

           services.AddAutoMapper(typeof(AbsenceAutoMapperConfiguration));
           services.AddAutoMapper(typeof(AbsenceApprovalAutoMapperConfiguration));
           services.AddAutoMapper(typeof(AbsenceTypeAutoMapperConfiguration));
           services.AddAutoMapper(typeof(BusinessAutoMapperConfiguration));
           services.AddAutoMapper(typeof(BusinessAbsenceTypeAutoMapperConfiguration));
           services.AddAutoMapper(typeof(RoleAutoMapperConfiguration));
           services.AddAutoMapper(typeof(UserAutoMapperConfiguration));
           services.AddAutoMapper(typeof(UserRoleAutoMapperConfiguration));
       
        }

    }

}
