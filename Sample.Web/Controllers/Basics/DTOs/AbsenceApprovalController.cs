using System;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.Web.WebUtilities.Interfaces;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.UpdateServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.DTOs
{
 
    public class AbsenceApprovalController : CustomBaseController<AbsenceApprovalDTO, AbsenceApprovalView, IAbsenceApprovalUpdateService, IAbsenceApprovalQueryService, long>
    {
        private readonly Lazy<IAbsenceApprovalQueryService> _entityQueryService;
        private readonly Lazy<IAbsenceApprovalUpdateService> _entityUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<IApiExceptionBuilder> _apiExceptionBuilder;

        public AbsenceApprovalController(Lazy<IAbsenceApprovalQueryService> entityQueryService,
                                     Lazy<IAbsenceApprovalUpdateService> entityUpdateService,
                                     Lazy<ISystemServiceProvider> systemServiceProvider,
                                     Lazy<IApiExceptionBuilder> apiExceptionBuilder) :
            base(entityQueryService, entityUpdateService, systemServiceProvider, apiExceptionBuilder)
        {

           _entityQueryService = entityQueryService;
           _entityUpdateService = entityUpdateService;
           _apiExceptionBuilder = apiExceptionBuilder;

        }


    }

}


