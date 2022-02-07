using System;
using AutoMapper;
using Sample.BLLayer.BLUtilities.Interfaces;
using Sample.DataLayer.DataUtilities.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;

namespace Sample.BLLayer.BLUtilities.Abstractions
{
    public abstract class EntityMapping<TEntity, TEntityDTO, TKey> : IMapping<TEntity, TEntityDTO>
        where TEntity : IBaseEntity<TKey>
        where TEntityDTO : IBaseEntityDTO<TKey>

    {
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;
        public EntityMapping(Lazy<ISystemServiceProvider> systemServiceProvider, 
                             IMapper mapper)
        {
            _systemServiceProvider = systemServiceProvider;
            _mapper = mapper;
        }
        public virtual TEntity MapEntity(TEntity entity, 
                                      TEntityDTO entityDto,
                                      bool isNewEntity)
        {
            var loggedUserName = _systemServiceProvider.Value.GetCurrentUserId();

            if (isNewEntity)
            {
                entityDto.CreatedDate = DateTimeOffset.UtcNow;
                entityDto.CreatedBy = loggedUserName.ToString();
            }
            entityDto.UpdatedDate = DateTimeOffset.UtcNow;
            entityDto.UpdatedBy = loggedUserName.ToString();
            entity = _mapper.Map<TEntity>(entityDto);
            return entity;
        }

    }
}
