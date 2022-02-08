using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.BLLayer.BLUtilities.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.BLUtilities.HelperModels;
using Sample.BLLayer.Extends.ExtendModels;

namespace Sample.BLLayer.QueryServices.Interfaces
{
 
    public interface IAbsenceQueryService : IQueryService<AbsenceDTO, AbsenceView>
    {
        public Task<PagedResponse<List<AbsenceView>>> GetCustomPaginationAsync(PaginationFilter filter, string route, AbsenceViewFilters absenceViewFilters);
     }

}