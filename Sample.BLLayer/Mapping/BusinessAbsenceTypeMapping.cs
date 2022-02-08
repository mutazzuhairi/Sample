using System;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.BLLayer.Mapping
{
 
    public partial class BusinessAbsenceTypeMapping : EntityMapping<BusinessAbsenceType, BusinessAbsenceTypeDTO, long>, IBusinessAbsenceTypeMapping
    {

        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;

        public BusinessAbsenceTypeMapping(Lazy<ISystemServiceProvider> systemServiceProvider,
                                    IMapper mapper) : base(systemServiceProvider, mapper)
        {
          
           _systemServiceProvider = systemServiceProvider;
           _mapper = mapper;

        }
        public void BusinessAbsenceTypeMapEntity(BusinessAbsenceType  entity, 
                                       BusinessAbsenceTypeDTO entityDTO,
                                       bool isNewEntity)
        {
            
        }

    }

}


