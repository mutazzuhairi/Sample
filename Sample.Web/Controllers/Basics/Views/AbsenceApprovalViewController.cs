using System;
using Sample.BLLayer.EntityDTOs;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.Views
{
 
    public class AbsenceApprovalViewController : CustomBaseViewController<AbsenceApprovalDTO, AbsenceApprovalView, IAbsenceApprovalQueryService, long>
    {

        private readonly Lazy<IAbsenceApprovalQueryService> _entityQueryService;    
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public AbsenceApprovalViewController(Lazy<IAbsenceApprovalQueryService> entityQueryService,                                      
                                               Lazy<ISystemServiceProvider> systemServiceProvider) :
            base(entityQueryService, systemServiceProvider)
        {
        
          _entityQueryService = entityQueryService;
        }


    }

}




