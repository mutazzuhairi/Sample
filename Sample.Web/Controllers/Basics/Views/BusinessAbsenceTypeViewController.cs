using System;
using Sample.BLLayer.EntityDTOs;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.Views
{
 
    public class BusinessAbsenceTypeViewController : CustomBaseViewController<BusinessAbsenceTypeDTO, BusinessAbsenceTypeView, IBusinessAbsenceTypeQueryService, long>
    {

        private readonly Lazy<IBusinessAbsenceTypeQueryService> _entityQueryService;    
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public BusinessAbsenceTypeViewController(Lazy<IBusinessAbsenceTypeQueryService> entityQueryService,                                      
                                               Lazy<ISystemServiceProvider> systemServiceProvider) :
            base(entityQueryService, systemServiceProvider)
        {
        
          _entityQueryService = entityQueryService;
        }


    }

}




