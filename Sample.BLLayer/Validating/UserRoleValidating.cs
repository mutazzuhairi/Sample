using System;
using System.Collections.Generic;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.Validating.Interfaces;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;

namespace Sample.BLLayer.Validating
{
 
    public class UserRoleValidating : IUserRoleValidating
    { 
        private readonly Lazy<IUserRoleQueryService> _entityQueryService;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly Lazy<IServiceBuildException> _serviceBuildException;

        public UserRoleValidating(Lazy<IUserRoleQueryService> entityQueryService,
                                      Lazy<ICommonServices> commonServices,
                                      Lazy<IServiceBuildException> serviceBuildException)
        {

            _entityQueryService = entityQueryService;
            _commonServices = commonServices;
            _serviceBuildException = serviceBuildException;

        }
        public void Validate(UserRoleDTO entityDTO, bool isNewEntity)
        {

        }
 
    }

}
