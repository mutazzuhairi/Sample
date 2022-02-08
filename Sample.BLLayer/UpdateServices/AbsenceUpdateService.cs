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
 
    public class AbsenceUpdateService : EntityUpdateService<Absence, IAbsenceRepositry, AbsenceDTO, IAbsenceMapping, IAbsenceValidating, long>, IAbsenceUpdateService
    {

        private readonly Lazy<IAbsenceRepositry> _entityRepositry;
        private readonly Lazy<IAbsenceValidating> _entityValidating;
        private readonly Lazy<IAbsenceMapping> _entityMapping;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly Lazy<IServiceBuildException> _serviceBuildException;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;
        private readonly Lazy<ICacheProvider> _cacheProvider;

        public AbsenceUpdateService(Lazy<IAbsenceRepositry> entityRepositry,
                                    Lazy<IAbsenceValidating> entityValidating,
                                    Lazy<IAbsenceMapping> entityMapping,
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