using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.BLLayer.BLUtilities.HelperModels;

namespace Sample.BLLayer.BLUtilities.Interfaces
{
    public interface IQueryService<TEntityDTO, TEntityView>
    {
        Task<List<TEntityDTO>> GetAllAsync(string route);
        Task<TEntityDTO> GetSingleAsync(string route, params object[] keyValues);
        Task<TEntityView> GetSingleViewAsync(string route, params object[] keyValues);
        Task<List<TEntityView>> GetAllViewAsync(string route);
        Task<PagedResponse<List<TEntityDTO>>> GetPaginationAsync(PaginationFilter filter, string route);
        Task<PagedResponse<List<TEntityView>>> GetPaginationViewAsync(PaginationFilter filter, string route);

    }
}
