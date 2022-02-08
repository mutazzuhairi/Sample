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
using Sample.BLLayer.BLUtilities.HelperModels;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sample.BLLayer.Extends.ExtendModels;

namespace Sample.BLLayer.QueryServices
{
 
    public class AbsenceQueryService : EntityQueryService<Absence, IAbsenceRepositry, AbsenceDTO, AbsenceView, long>, IAbsenceQueryService
    {
        private readonly Lazy<IAbsenceRepositry> _entityRepositry;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly Lazy<IUriService> _uriService;
        private readonly Lazy<IPaginationHelper> _paginationHelper;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;
        private readonly Lazy<ICacheProvider> _cacheProvider;

        public AbsenceQueryService(Lazy<IAbsenceRepositry> entityRepositry, 
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

        public async Task<PagedResponse<List<AbsenceView>>> GetCustomPaginationAsync(PaginationFilter filter,  string route, AbsenceViewFilters absenceViewFilters)
        {

            var paginationData = await GetPaginationData(filter, route);
            var pagedData = await GetCustomPaginationRecoreds(paginationData.ValidFilter, absenceViewFilters);
            var pagedDataView = this._mapper.Map<List<AbsenceView>>(pagedData);

            return _paginationHelper.Value.CreatePagedReponse<AbsenceView>(pagedDataView, paginationData);

        }



        public async Task<List<Absence>> GetCustomPaginationRecoreds(PaginationFilter validFilter, AbsenceViewFilters absenceViewFilters)
        {

            var pagedData =  _entityRepositry.Value.AsQueryable().Where(s=>s.UserId == 5);
            if (absenceViewFilters.FromDate != null)
            {
                pagedData = pagedData.Where(s=> s.FromDate >= absenceViewFilters.FromDate);
            }
            if (absenceViewFilters.ToDate != null)
            {
                pagedData = pagedData.Where(s => s.ToDate <= absenceViewFilters.ToDate);
            }
            if (absenceViewFilters.Created != null)
            {
                pagedData =  pagedData.Where(s => s.CreatedDate.DateTime.Date == absenceViewFilters.ToDate.Value.Date);
            }
            if (absenceViewFilters.AbsenceType != null)
            {
                pagedData = pagedData.Where(s => s.BusinessAbsenceType.AbsenceType.Name == absenceViewFilters.AbsenceType);
            }

            var result = await pagedData.AsQueryable()
                                  .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                                  .Take(validFilter.PageSize)
                                  .ToListAsync();

            return result;
        }

    }
}