using System;
using AutoMapper;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sample.BLLayer.BLUtilities.Interfaces;
using Sample.BLLayer.BLUtilities.HelperModels;
using Sample.DataLayer.DataUtilities.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;

namespace Sample.BLLayer.BLUtilities.Abstractions
{
    public abstract class EntityQueryService<TEntity, TEntityRepositry, TEntityDTO, TEntityView, TKey> : IQueryService<TEntityDTO, TEntityView>
    where TEntity : IBaseEntity<TKey>
    where TEntityDTO : IBaseEntityDTO<TKey>
    where TEntityView : IBaseEntityView<TKey>
    where TEntityRepositry : IRepository<TEntity>
    {
        private readonly Lazy<TEntityRepositry> _entityRepositry;
        private readonly Lazy<IUriService> _uriService;
        private readonly Lazy<IPaginationHelper> _paginationHelper;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly IMapper _mapper;
        private readonly Lazy<ICacheProvider> _cacheProvider;
        public EntityQueryService(Lazy<TEntityRepositry> entityRepositry, 
                                  Lazy<IUriService> uriService,
                                  Lazy<IPaginationHelper> paginationHelper,
                                  Lazy<ISystemServiceProvider> systemServiceProvider,
                                  Lazy<ICommonServices> commonServices,
                                  IMapper mapper,
                                  Lazy<ICacheProvider> cacheProvider)
        {
            _entityRepositry = entityRepositry;
            _uriService = uriService;
            _paginationHelper = paginationHelper;
            _systemServiceProvider = systemServiceProvider;
            _commonServices = commonServices;
            _mapper = mapper;
            _cacheProvider = cacheProvider;
        }

        public virtual async Task<List<TEntityDTO>> GetAllAsync(string route)
        {
            var pocoList = await this._entityRepositry.Value.AsQueryable().Where(s => !s.Void).ToListAsync();
            List <TEntityDTO> result = _mapper.Map<List<TEntityDTO>>(pocoList);

            return result;

        }

        public virtual async Task<List<TEntityView>> GetAllViewAsync(string route)
        {
            var pocoList = await this._entityRepositry.Value.AsQueryable().Where(s => !s.Void).ToListAsync();
            List<TEntityView> result = _mapper.Map<List<TEntityView>>(pocoList);

            return result;

        }
         
        public virtual async Task<TEntityDTO> GetSingleAsync(string route, params object[] keyValues)
        {
            TKey key = (TKey)keyValues.FirstOrDefault();
            var poco = this._entityRepositry.Value.AsQueryable().Where(s => !s.Void && s.Id.Equals(key));
            poco = GetSingleEntityWithCustomIncludes(poco);
            var entity = await poco.FirstOrDefaultAsync();
            TEntityDTO result = default;
            if (entity != null)
            {
                var entityDTO = _mapper.Map<TEntityDTO>(entity);
                entityDTO = GetSingleEntityDTOMapping(entityDTO);
                result = _mapper.Map<TEntityDTO>(entityDTO);
            }
            else
            {
                return default(TEntityDTO);
            }
            return result;
        }

        public virtual async Task<TEntityView> GetSingleViewAsync(string route, params object[] keyValues)
        {
            TKey key = (TKey)keyValues.FirstOrDefault();
            var poco = this._entityRepositry.Value.AsQueryable().Where(s => !s.Void && s.Id.Equals(key));
            poco = GetSingleEntityWithCustomIncludes(poco);
            var entity = await poco.FirstOrDefaultAsync();
            TEntityView result = default;
            if (entity != null)
            {
                var entityView = _mapper.Map<TEntityView>(entity);
                entityView = GetSingleEntityViewMapping(entityView);
                result = _mapper.Map<TEntityView>(entityView);
            }
            else
            {
                return default(TEntityView);
            }
            return result;
        }


        public virtual async Task<PagedResponse<List<TEntityDTO>>> GetPaginationAsync(PaginationFilter filter, string route)
        {
            var paginationData = await GetPaginationData(filter, route);
            var pagedData = await GetPaginationRecoreds(paginationData.ValidFilter);
            var pagedDataDTO = this._mapper.Map<List<TEntityDTO>>(pagedData);
            pagedDataDTO = GetEntitiesDTOMapping(pagedDataDTO);
            PagedResponse<List<TEntityDTO>> result = _paginationHelper.Value.CreatePagedReponse<TEntityDTO>(pagedDataDTO, paginationData);

            return result;
        }

        public virtual async  Task<PagedResponse<List<TEntityView>>> GetPaginationViewAsync(PaginationFilter filter, string route)
        {
            var paginationData = await GetPaginationData(filter, route);
            var pagedData = await GetPaginationRecoreds(paginationData.ValidFilter);
            var pagedDataView = this._mapper.Map<List<TEntityView>>(pagedData);
            pagedDataView = GetEntitiesViewMapping(pagedDataView);
            PagedResponse<List<TEntityView>> result = _paginationHelper.Value.CreatePagedReponse<TEntityView>(pagedDataView, paginationData);
            return result;
        }

        public async Task<PaginationData> GetPaginationData(PaginationFilter filter, string route , IQueryable<TEntity> entities = null)
        {
            var validFilter = new PaginationFilter(filter, filter.PageNumber, filter.PageSize);
            var totalRecords = entities != null ? await entities.CountAsync() : await this._entityRepositry.Value.AsQueryable().Where(s => !s.Void).CountAsync();
            if (validFilter.GetAll)
            {
                validFilter.PageNumber = 1;
                validFilter.PageSize = totalRecords;
            }
            var paginationData = new PaginationData()
            {
                TotalRecords = totalRecords,
                ValidFilter = validFilter,
                Route = route,
                UriService = _uriService.Value,
            };

            return paginationData;
        }
        public virtual async Task<List<TEntity>> GetPaginationRecoreds(PaginationFilter validFilter)
        {
            var data = this._entityRepositry.Value.AsQueryable().Where(s => !s.Void);
            if (!string.IsNullOrEmpty(validFilter.SearchField))
            {
                data = data.Where(s => s.SearchField.Contains(validFilter.SearchField));
            }
            data = GetEntitiesWithCustomIncludes(data);
            var pagedData = await data
                                  .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                                  .Take(validFilter.PageSize)
                                  .ToListAsync();
            return pagedData;
        }

        public virtual async Task<PagedResponse<List<TEntityView>>> GetCustomPaginationAsync<EntityType>(PaginationFilter filter, 
                                                                                                             string route, 
                                                                                                             IQueryable<EntityType> entityData,
                                                                                                             int? totalRecords=null)
        {

            var paginationData = await GetPaginationData(filter, route);
            var pagedData = await GetCustomPaginationRecoreds<EntityType>(paginationData.ValidFilter, entityData);
            var pagedDataView = this._mapper.Map<List<TEntityView>>(pagedData);

            return _paginationHelper.Value.CreatePagedReponse<TEntityView>(pagedDataView, paginationData);

        }



        public virtual async Task<List<EntityType>> GetCustomPaginationRecoreds<EntityType>(PaginationFilter validFilter,
                                                                                            IQueryable<EntityType> entityData)
        {
            var pagedData = await entityData
                                  .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                                  .Take(validFilter.PageSize)
                                  .ToListAsync();

            return pagedData;
        }


        public virtual TEntityDTO GetSingleEntityDTOMapping(TEntityDTO entity)
        {


            return entity;
        }

        public virtual TEntityView GetSingleEntityViewMapping(TEntityView entity)
        {


            return entity;
        }

        public virtual List<TEntityDTO> GetEntitiesDTOMapping(List<TEntityDTO> entities)
        {


            return entities;
        }

        public virtual List<TEntityView> GetEntitiesViewMapping(List<TEntityView> entities)
        {


            return entities;
        }

        public virtual IQueryable<TEntity> GetSingleEntityWithCustomIncludes(IQueryable<TEntity> entity)
        {


            return entity;
        }

        public virtual IQueryable<TEntity> GetEntitiesWithCustomIncludes(IQueryable<TEntity> entities)
        {

            return entities;
        }

    }
}
