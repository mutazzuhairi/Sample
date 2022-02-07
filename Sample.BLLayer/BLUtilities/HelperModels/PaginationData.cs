using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;

namespace Sample.BLLayer.BLUtilities.HelperModels
{
    public class PaginationData
    {
        public PaginationFilter ValidFilter { get; set; }
        public int TotalRecords { get; set; }
        public IUriService UriService { get; set; }
        public string Route { get; set; }

    }
}
