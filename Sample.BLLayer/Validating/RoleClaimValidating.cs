using System;
using System.Collections.Generic;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.Validating.Interfaces;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;

namespace Sample.BLLayer.Validating
{
 
    public class RoleClaimValidating : IRoleClaimValidating
    { 
        private readonly Lazy<IRoleClaimQueryService> _entityQueryService;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly Lazy<IServiceBuildException> _serviceBuildException;

        public RoleClaimValidating(Lazy<IRoleClaimQueryService> entityQueryService,
                                      Lazy<ICommonServices> commonServices,
                                      Lazy<IServiceBuildException> serviceBuildException)
        {

            _entityQueryService = entityQueryService;
            _commonServices = commonServices;
            _serviceBuildException = serviceBuildException;

        }
        public void Validate(RoleClaimDTO entityDTO, bool isNewEntity)
        {

        }
 
    }

}
