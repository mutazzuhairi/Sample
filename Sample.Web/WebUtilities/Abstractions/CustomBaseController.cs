using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Sample.BLLayer.BLUtilities.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;
using Sample.BLLayer.BLUtilities.HelperModels;
using Sample.Web.WebUtilities.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.Web.WebUtilities.Abstractions
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public abstract class CustomBaseController<TEntityDTO, TEntityView, TUpdateService, TQueryService, Tkey> : ControllerBase
        where TEntityDTO : IBaseEntityDTO<Tkey>
        where TUpdateService : IUpdateService<TEntityDTO>
        where TQueryService : IQueryService<TEntityDTO, TEntityView>
    {

        private readonly Lazy<TQueryService> _entityQueryService;
        private readonly Lazy<TUpdateService> _entityUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<IApiExceptionBuilder> _apiExceptionBuildercs;

        public CustomBaseController(Lazy<TQueryService> entityQueryService,
                                    Lazy<TUpdateService> entityUpdateService,
                                    Lazy<ISystemServiceProvider> systemServiceProvider,
                                    Lazy<IApiExceptionBuilder> apiExceptionBuildercs)
        {
            _entityQueryService = entityQueryService;
            _entityUpdateService = entityUpdateService;
            _apiExceptionBuildercs = apiExceptionBuildercs;
            _systemServiceProvider = systemServiceProvider;
        }

        [HttpGet]
        public virtual async Task<ActionResult<PagedResponse<List<TEntityDTO>>>> GetAll([FromQuery] PaginationFilter filter)
        {
            string route = Request.Path.Value;
            PagedResponse<List<TEntityDTO>> tEntityViews = await _entityQueryService.Value.GetPaginationAsync(filter, route);
            return Ok(new Response<PagedResponse<List<TEntityDTO>>>(tEntityViews));

        }


        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntityDTO>> Get(Tkey id)
        {
            string route = Request.Path.Value;
            TEntityDTO tEntityView = await _entityQueryService.Value.GetSingleAsync(route, id);
            if (tEntityView == null)
                return NotFound();
            return Ok(new Response<TEntityDTO>(tEntityView));

        }
 

        [HttpPost]
        public virtual async Task<ActionResult<TEntityDTO>> Post(TEntityDTO entityDTO)
        {

            entityDTO = await _entityUpdateService.Value.CreateAsync(entityDTO);
            return Ok(new Response<TEntityDTO>(entityDTO));

        }

        //[HttpPut]
        //public virtual async Task<ActionResult<TEntityDTO>> Put(Tkey id, TEntityDTO entityDTO)
        //{

        //    entityDTO = await _entityUpdateService.Value.UpdateAsync(entityDTO, id);
        //    if (entityDTO == null)
        //        return NotFound();
        //    return Ok(new Response<TEntityDTO>(entityDTO));

        //}


        //[HttpDelete("{id}")]
        //public virtual async Task<ActionResult<TEntityDTO>> Delete(Tkey id)
        //{

        //    TEntityDTO entityDTO = await _entityUpdateService.Value.DeleteAsync(id);
        //    if (entityDTO == null)
        //        return NotFound();
        //    return Ok(new Response<TEntityDTO>(entityDTO));

        //}


    }
}
