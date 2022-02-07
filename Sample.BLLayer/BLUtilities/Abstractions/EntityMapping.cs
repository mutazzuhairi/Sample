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
            var loggedUserId = _systemServiceProvider.Value.GetCurrentUserId();
            entityDto.CreatedBy = entity.CreatedBy;
            entityDto.CreatedDate = entity.CreatedDate;
            var version = entity.Version;
            if (isNewEntity)
            {
                entityDto.CreatedDate = DateTimeOffset.UtcNow;
                entityDto.CreatedBy = loggedUserId?.ToString() ?? "System";
            }
            entityDto.UpdatedDate = DateTimeOffset.UtcNow;
            entityDto.UpdatedBy = loggedUserId?.ToString() ?? "System";
            entityDto.Id = entity.Id;
            entityDto.SearchField = entity.SearchField;
            entity = _mapper.Map<TEntity>(entityDto);
            entity.Version = version;
            return entity;
        }

    }
}
