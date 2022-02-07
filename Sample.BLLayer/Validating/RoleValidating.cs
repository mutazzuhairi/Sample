using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.Validating.Interfaces;
using System.Collections.Generic;
using System;

namespace Sample.BLLayer.Validating
{
 
    public class RoleValidating : IRoleValidating
    { 
        private readonly Lazy<IRoleQueryService> _entityQueryService;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly Lazy<IServiceBuildException> _serviceBuildException;

        public RoleValidating(Lazy<IRoleQueryService> entityQueryService,
                                      Lazy<ICommonServices> commonServices,
                                      Lazy<IServiceBuildException> serviceBuildException)
        {

            _entityQueryService = entityQueryService;
            _commonServices = commonServices;
            _serviceBuildException = serviceBuildException;

        }
        public void Validate(RoleDTO entityDTO, bool isNewEntity)
        {

        }
 
    }

}
