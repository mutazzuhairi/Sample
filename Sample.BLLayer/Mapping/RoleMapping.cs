using System;
using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.BLLayer.Mapping
{
 
    public partial class  RoleMapping : EntityMapping<Role, RoleDTO, long>, IRoleMapping
    {

        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;

        public RoleMapping(Lazy<ISystemServiceProvider> systemServiceProvider,
                                    IMapper mapper) : base(systemServiceProvider, mapper)
        {
           _systemServiceProvider = systemServiceProvider;
           _mapper = mapper;
        }
        public void RoleMapEntity(Role  entity, 
                                       RoleDTO entityDTO,
                                       bool isNewEntity)
        {
            
        }

    }

}


