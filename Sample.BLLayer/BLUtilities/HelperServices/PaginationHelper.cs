﻿using System;
using System.Collections.Generic;
using Sample.BLLayer.BLUtilities.HelperModels;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;

namespace Sample.BLLayer.BLUtilities.HelperServices
{
    public class PaginationHelper: IPaginationHelper
    {
        public   PagedResponse<List<T>> CreatePagedReponse<T>(List<T> pagedData, PaginationData paginationData)
        {
            var respose = new PagedResponse<List<T>>(pagedData, paginationData.ValidFilter.PageNumber, paginationData.ValidFilter.PageSize);
            var totalPages = ((double)paginationData.TotalRecords / (double)paginationData.ValidFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            respose.NextPage =
                paginationData.ValidFilter.PageNumber >= 1 && paginationData.ValidFilter.PageNumber < roundedTotalPages
                ? paginationData.UriService.GetPageUri(new PaginationFilter(paginationData.ValidFilter,
                                                                            paginationData.ValidFilter.PageNumber + 1, 
                                                                            paginationData.ValidFilter.PageSize), paginationData.Route)
                : null;
            respose.PreviousPage =
                paginationData.ValidFilter.PageNumber - 1 >= 1 && paginationData.ValidFilter.PageNumber <= roundedTotalPages
                ? paginationData.UriService.GetPageUri(new PaginationFilter(paginationData.ValidFilter,
                                                                            paginationData.ValidFilter.PageNumber - 1, 
                                                                            paginationData.ValidFilter.PageSize), paginationData.Route)
                : null;
            respose.FirstPage = paginationData.UriService.GetPageUri(new PaginationFilter(paginationData.ValidFilter,
                                                                                          1, 
                                                                                          paginationData.ValidFilter.PageSize), paginationData.Route);
            respose.LastPage = paginationData.UriService.GetPageUri(new PaginationFilter(paginationData.ValidFilter, 
                                                                                         roundedTotalPages, 
                                                                                         paginationData.ValidFilter.PageSize), paginationData.Route);
            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = paginationData.TotalRecords;

            return respose;
        }
    }
}
