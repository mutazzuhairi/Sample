using System;
using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;
using Sample.BLLayer.BLUtilities.HelperServices;
using Sample.DataLayer.Data.Repositries.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;

namespace Sample.BLLayer.QueryServices
{
 
    public class AbsenceTypeQueryService : EntityQueryService<AbsenceType, IAbsenceTypeRepositry, AbsenceTypeDTO, AbsenceTypeView, long>, IAbsenceTypeQueryService
    {
        private readonly Lazy<IAbsenceTypeRepositry> _entityRepositry;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly Lazy<IUriService> _uriService;
        private readonly Lazy<IPaginationHelper> _paginationHelper;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;
        private readonly Lazy<ICacheProvider> _cacheProvider;

        public AbsenceTypeQueryService(Lazy<IAbsenceTypeRepositry> entityRepositry, 
                                Lazy<ICommonServices> commonServices,
                                Lazy<IUriService> uriService,
                                Lazy<IPaginationHelper> paginationHelper,
                                Lazy<ISystemServiceProvider> systemServiceProvider,
                                IMapper mapper,
                                Lazy<ICacheProvider> cacheProvider) :
            base(entityRepositry, uriService, paginationHelper, systemServiceProvider, commonServices, mapper, cacheProvider)
        {

            _entityRepositry = entityRepositry;
            _commonServices = commonServices;
            _uriService = uriService;
            _paginationHelper = paginationHelper;
            _systemServiceProvider = systemServiceProvider;
            _mapper = mapper;
            _cacheProvider = cacheProvider;
        }

    }
}