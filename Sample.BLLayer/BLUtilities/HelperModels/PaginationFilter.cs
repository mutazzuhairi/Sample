
using System.Collections.Generic;

namespace Sample.BLLayer.BLUtilities.HelperModels
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; }
        public bool GetAll { get; set; }
        public string SearchField { get; set; }
        public int PageSize { get; set; }
        public string FilterValues { get; set; }
        public string SortBy { get; set; }
        public string ExtraAction { get; set; }
        public PaginationFilter()
        {
            this.PageNumber = 1;
            this.PageSize = 12;
            this.GetAll = false;
        }
        public PaginationFilter(PaginationFilter filter, int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize < 0 ? 0 : pageSize;
            this.GetAll = filter.GetAll;
            this.FilterValues = filter.FilterValues;
            this.SortBy = filter.SortBy;
            this.ExtraAction = filter.ExtraAction;
            this.SearchField = filter.SearchField?.Trim() == string.Empty ? null : filter.SearchField;
        }
    }
}
