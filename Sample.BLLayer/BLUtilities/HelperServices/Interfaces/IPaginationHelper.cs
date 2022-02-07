using System.Collections.Generic;
using Sample.BLLayer.BLUtilities.HelperModels;

namespace Sample.BLLayer.BLUtilities.HelperServices.Interfaces
{
    public interface IPaginationHelper 
    {
        public   PagedResponse<List<T>> CreatePagedReponse<T>(List<T> pagedData, PaginationData paginationData);
    }
}
