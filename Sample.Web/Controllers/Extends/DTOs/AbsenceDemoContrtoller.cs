
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Sample.BLLayer.Extends.ExtendModels;
using AutoMapper;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;
using Sample.BLLayer.BLUtilities.HelperModels;
using Sample.BLLayer.UpdateServices.Interfaces;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Sample.BLLayer.QueryServices.Interfaces;
using System.Collections.Generic;
using Sample.BLLayer.EntityViews;

namespace Sample.Web.Controllers.Extends.DTOs
{
    [ApiController]
    [Route("api/[controller]")]
    public class AbsenceDemo : ControllerBase
    {
        private readonly Lazy<IAbsenceUpdateService> _absenceUpdateService;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<IAbsenceQueryService> _absenceQueryService;
        private readonly IMapper _mapper;

        public AbsenceDemo(Lazy<IAbsenceUpdateService> absenceUpdateService,
                           Lazy<ISystemServiceProvider> systemServiceProvider,
                           Lazy<IAbsenceQueryService> absenceQueryService,
                           IMapper mapper)
        {
            _absenceUpdateService = absenceUpdateService;
            _systemServiceProvider = systemServiceProvider;
            _absenceQueryService = absenceQueryService;
            _mapper = mapper;
        }


        [HttpPost]
        public async Task<ActionResult<AbsenceDTO>> Post([FromBody] AbsenceDemoDTO absenceDTO)
        {

            var authResult = await _absenceUpdateService.Value.CreateCustomAsync(absenceDTO);
            return Ok(new Response<AbsenceDTO>(authResult));

        }


        [HttpGet]
        public virtual async Task<ActionResult<PagedResponse<List<AbsenceView>>>> GetAll([FromQuery] PaginationFilter filter, [FromQuery] AbsenceViewFilters absenceViewFilters)
        {

            string route = Request.Path.Value;
            PagedResponse<List<AbsenceView>> tEntityViews = await _absenceQueryService.Value.GetCustomPaginationAsync(filter, route, absenceViewFilters);
            return Ok(new Response<PagedResponse<List<AbsenceView>>>(tEntityViews));

        }
         
    }
}
