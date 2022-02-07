using System;
using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.Validating.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;
using Sample.BLLayer.UpdateServices.Interfaces;
using Sample.DataLayer.Data.Repositries.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;

namespace Sample.BLLayer.UpdateServices
{
 
    public class UserClaimUpdateService : EntityUpdateService<UserClaim, IUserClaimRepositry, UserClaimDTO, IUserClaimMapping, IUserClaimValidating, int>, IUserClaimUpdateService
    {

        private readonly Lazy<IUserClaimRepositry> _entityRepositry;
        private readonly Lazy<IUserClaimValidating> _entityValidating;
        private readonly Lazy<IUserClaimMapping> _entityMapping;
        private readonly Lazy<IServiceBuildException> _serviceBuildException;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly IMapper _mapper;
        private readonly Lazy<ICacheProvider> _cacheProvider;

        public UserClaimUpdateService(Lazy<IUserClaimRepositry> entityRepositry,
                                    Lazy<IUserClaimValidating> entityValidating,
                                    Lazy<IUserClaimMapping> entityMapping,
                                    Lazy<IServiceBuildException> serviceBuildException,
                                    Lazy<ISystemServiceProvider> systemServiceProvider,
                                    Lazy<ICommonServices> commonServices,
                                    IMapper mapper,
                                    Lazy<ICacheProvider> cacheProvider) :
            base(entityRepositry, entityValidating, entityMapping, serviceBuildException, systemServiceProvider, commonServices, mapper, cacheProvider)
        {
            _entityRepositry = entityRepositry;
            _entityValidating = entityValidating;
            _entityMapping = entityMapping;
            _serviceBuildException = serviceBuildException;
            _systemServiceProvider = systemServiceProvider;
            _commonServices = commonServices;
            _mapper = mapper;
            _cacheProvider = cacheProvider;
        }
 
    }

}