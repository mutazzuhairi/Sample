using Sample.BLLayer.EntityDTOs;
using System.Collections.Generic;
using Sample.BLLayer.BLUtilities.Interfaces;
using Sample.BLLayer.Validating.Interfaces;
using System;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Sample.BLLayer.BLUtilities.SystemConstants;
using Sample.BLLayer.QueryServices.Interfaces;

namespace Sample.BLLayer.Validating
{
    public class UserValidating : IUserValidating
    {
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly Lazy<IServiceBuildException> _serviceBuildException;
        private readonly Lazy<IUserQueryService> _entityQueryService;

        public UserValidating(Lazy<ICommonServices> commonServices,
                              Lazy<IServiceBuildException> serviceBuildException,
                              Lazy<IUserQueryService> entityQueryService)
        {
            _commonServices = commonServices;
            _serviceBuildException = serviceBuildException;
            _entityQueryService = entityQueryService;
        }
        public void Validate(UserDTO entityDTO, bool isNewEntity)
        {
            if (!IsEmailValid(entityDTO.UserName))
            {
                _serviceBuildException.Value.BuildException("UserName", BLLayerConstatnts.ValidationMessage.EMAIL_NOT_VALID);
            }
            else if (IsUserNameAlreadyExist(entityDTO.UserName,   entityDTO.Id))
            {
                _serviceBuildException.Value.BuildException("UserName", BLLayerConstatnts.ValidationMessage.USER_NAME_ALREADY_EXIST);
            }
        }


        private bool IsEmailValid(string email)
        {
            return _commonServices.Value.IsEmailValid(email);
        }

        private bool IsUserNameAlreadyExist(string userName,long entityId)
        {
            return _entityQueryService.Value.IsUserNameAlreadyExist(userName, entityId);
        }
    }
}
