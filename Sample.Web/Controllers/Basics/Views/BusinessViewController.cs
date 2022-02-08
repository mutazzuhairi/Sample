using System;
using Sample.BLLayer.EntityDTOs;
using Sample.Web.WebUtilities.Abstractions;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.Controllers.Basics.Views
{
 
    public class BusinessViewController : CustomBaseViewController<BusinessDTO, BusinessView, IBusinessQueryService, long>
    {

        private readonly Lazy<IBusinessQueryService> _entityQueryService;    
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public BusinessViewController(Lazy<IBusinessQueryService> entityQueryService,                                      
                                               Lazy<ISystemServiceProvider> systemServiceProvider) :
            base(entityQueryService, systemServiceProvider)
        {
        
          _entityQueryService = entityQueryService;
        }


    }

}



