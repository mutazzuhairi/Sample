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
 
    public class BusinessAbsenceTypeController : CustomBaseController<BusinessAbsenceTypeDTO, BusinessAbsenceTypeView, IBusinessAbsenceTypeUpdateService, IBusinessAbsenceTypeQueryService, long>
    {
        private readonly Lazy<IBusinessAbsenceTypeQueryService> _entityQueryService;
        private readonly Lazy<IBusinessAbsenceTypeUpdateService> _entityUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<IApiExceptionBuilder> _apiExceptionBuilder;

        public BusinessAbsenceTypeController(Lazy<IBusinessAbsenceTypeQueryService> entityQueryService,
                                     Lazy<IBusinessAbsenceTypeUpdateService> entityUpdateService,
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


