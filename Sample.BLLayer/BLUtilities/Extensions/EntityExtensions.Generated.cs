using Microsoft.Extensions.DependencyInjection;
using Sample.BLLayer.Mapping;
using Sample.BLLayer.QueryServices;
using Sample.BLLayer.UpdateServices;
using Sample.BLLayer.Validating;
using Sample.DataLayer.Data.Repositries;
using Sample.DataLayer.Data.Repositries.Interfaces;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.UpdateServices.Interfaces;
using Sample.BLLayer.Validating.Interfaces;

namespace Sample.BLLayer.BLUtilities.Extensions
{
 
    public static class EntityExtensions
    {

        public static void AddEntityServicesToConfigure(this IServiceCollection services)
        {
            AddRepositriesToScope(services);
            AddMappingToScope(services);
            AddValidatingToScope(services);
            AddQueryServicesToScope(services);
            AddUpdateServicesToScope(services);
        }

        private static void AddRepositriesToScope(IServiceCollection services)
        {

           services.AddScoped<IAbsenceRepositry, AbsenceRepositry>();
           services.AddScoped<IAbsenceApprovalRepositry, AbsenceApprovalRepositry>();
           services.AddScoped<IAbsenceTypeRepositry, AbsenceTypeRepositry>();
           services.AddScoped<IBusinessRepositry, BusinessRepositry>();
           services.AddScoped<IBusinessAbsenceTypeRepositry, BusinessAbsenceTypeRepositry>();
           services.AddScoped<IRoleRepositry, RoleRepositry>();
           services.AddScoped<IRoleClaimRepositry, RoleClaimRepositry>();
           services.AddScoped<IUserRepositry, UserRepositry>();
           services.AddScoped<IUserClaimRepositry, UserClaimRepositry>();
           services.AddScoped<IUserLoginRepositry, UserLoginRepositry>();
           services.AddScoped<IUserRoleRepositry, UserRoleRepositry>();
           services.AddScoped<IUserTokenRepositry, UserTokenRepositry>();
       
        }

        private static void AddValidatingToScope(IServiceCollection services)
        {

           services.AddScoped<IAbsenceValidating, AbsenceValidating>();
           services.AddScoped<IAbsenceApprovalValidating, AbsenceApprovalValidating>();
           services.AddScoped<IAbsenceTypeValidating, AbsenceTypeValidating>();
           services.AddScoped<IBusinessValidating, BusinessValidating>();
           services.AddScoped<IBusinessAbsenceTypeValidating, BusinessAbsenceTypeValidating>();
           services.AddScoped<IRoleValidating, RoleValidating>();
           services.AddScoped<IUserValidating, UserValidating>();
           services.AddScoped<IUserRoleValidating, UserRoleValidating>();
       
        }

        private static void AddMappingToScope(IServiceCollection services)
        {

           services.AddScoped<IAbsenceMapping, AbsenceMapping>();
           services.AddScoped<IAbsenceApprovalMapping, AbsenceApprovalMapping>();
           services.AddScoped<IAbsenceTypeMapping, AbsenceTypeMapping>();
           services.AddScoped<IBusinessMapping, BusinessMapping>();
           services.AddScoped<IBusinessAbsenceTypeMapping, BusinessAbsenceTypeMapping>();
           services.AddScoped<IRoleMapping, RoleMapping>();
           services.AddScoped<IUserMapping, UserMapping>();
           services.AddScoped<IUserRoleMapping, UserRoleMapping>();
       
        }

        private static void AddUpdateServicesToScope(IServiceCollection services)
        {

           services.AddScoped<IAbsenceUpdateService, AbsenceUpdateService>();
           services.AddScoped<IAbsenceApprovalUpdateService, AbsenceApprovalUpdateService>();
           services.AddScoped<IAbsenceTypeUpdateService, AbsenceTypeUpdateService>();
           services.AddScoped<IBusinessUpdateService, BusinessUpdateService>();
           services.AddScoped<IBusinessAbsenceTypeUpdateService, BusinessAbsenceTypeUpdateService>();
           services.AddScoped<IRoleUpdateService, RoleUpdateService>();
           services.AddScoped<IUserUpdateService, UserUpdateService>();
           services.AddScoped<IUserRoleUpdateService, UserRoleUpdateService>();
       
        }

        private static void AddQueryServicesToScope(IServiceCollection services)
        {

           services.AddScoped<IAbsenceQueryService, AbsenceQueryService>();
           services.AddScoped<IAbsenceApprovalQueryService, AbsenceApprovalQueryService>();
           services.AddScoped<IAbsenceTypeQueryService, AbsenceTypeQueryService>();
           services.AddScoped<IBusinessQueryService, BusinessQueryService>();
           services.AddScoped<IBusinessAbsenceTypeQueryService, BusinessAbsenceTypeQueryService>();
           services.AddScoped<IRoleQueryService, RoleQueryService>();
           services.AddScoped<IUserQueryService, UserQueryService>();
           services.AddScoped<IUserRoleQueryService, UserRoleQueryService>();
       
        }
    }
}
