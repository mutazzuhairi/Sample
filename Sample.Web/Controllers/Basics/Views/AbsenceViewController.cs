using System;
using Sample.BLLayer.EntityDTOs;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.Views
{
 
    public class AbsenceViewController : CustomBaseViewController<AbsenceDTO, AbsenceView, IAbsenceQueryService, long>
    {

        private readonly Lazy<IAbsenceQueryService> _entityQueryService;    
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public AbsenceViewController(Lazy<IAbsenceQueryService> entityQueryService,                                      
                                               Lazy<ISystemServiceProvider> systemServiceProvider) :
            base(entityQueryService, systemServiceProvider)
        {
        
          _entityQueryService = entityQueryService;
        }


    }

}




