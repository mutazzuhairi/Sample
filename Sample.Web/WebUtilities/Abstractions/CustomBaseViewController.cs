using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Sample.BLLayer.BLUtilities.Interfaces;
using Sample.BLLayer.BLUtilities.HelperModels;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices;
using System.ComponentModel.DataAnnotations;

namespace Sample.Web.WebUtilities.Abstractions
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class CustomBaseViewController<TEntityDTO, TEntityView, TQueryService, Tkey> : ControllerBase
        where TQueryService : IQueryService<TEntityDTO, TEntityView>
    {

        private readonly Lazy<TQueryService> _entityQueryService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;

        public CustomBaseViewController(Lazy<TQueryService> entityQueryService,
                                        Lazy<ISystemServiceProvider> systemServiceProvider)
        {
            _entityQueryService = entityQueryService;
            _systemServiceProvider = systemServiceProvider;
        }

        [HttpGet]
        public virtual async Task<ActionResult<PagedResponse<List<TEntityView>>>> GetAll([FromQuery] PaginationFilter filter)
        {

            string route = Request.Path.Value;
            PagedResponse<List<TEntityView>> tEntityViews = await _entityQueryService.Value.GetPaginationViewAsync(filter, route);
            return Ok(new Response<PagedResponse<List<TEntityView>>>(tEntityViews));

        }


        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntityView>> Get([Required][FromQuery] Tkey id)
        {
            string route = Request.Path.Value;
            TEntityView tEntityView = await _entityQueryService.Value.GetSingleViewAsync(route, id);
            if (tEntityView == null)
                return NotFound();
            return Ok(new Response<TEntityView>(tEntityView));

        }

    }
}
