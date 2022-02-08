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
 
    public partial class AbsenceMapping : EntityMapping<Absence, AbsenceDTO, long>, IAbsenceMapping
    {

        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;

        public AbsenceMapping(Lazy<ISystemServiceProvider> systemServiceProvider,
                                    IMapper mapper) : base(systemServiceProvider, mapper)
        {
          
           _systemServiceProvider = systemServiceProvider;
           _mapper = mapper;

        }
        public void AbsenceMapEntity(Absence  entity, 
                                       AbsenceDTO entityDTO,
                                       bool isNewEntity)
        {
            
        }

    }

}


