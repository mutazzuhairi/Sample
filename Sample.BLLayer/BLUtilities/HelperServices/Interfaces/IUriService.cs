using System;
using Sample.BLLayer.BLUtilities.HelperModels;

namespace Sample.BLLayer.BLUtilities.HelperServices.Interfaces
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
