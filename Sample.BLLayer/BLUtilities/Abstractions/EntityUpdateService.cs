using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AutoMapper;
using Sample.BLLayer.BLUtilities.Interfaces;
using Sample.DataLayer.DataUtilities.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;

namespace Sample.BLLayer.BLUtilities.Abstractions
{
    public abstract class EntityUpdateService<TEntity, TEntityRepositry, TEntityDTO, TEntityMapping, TEntityValidating, TKey> : IUpdateService<TEntityDTO>
        where TEntity : IBaseEntity<TKey>
        where TEntityDTO : IBaseEntityDTO<TKey>
        where TEntityValidating : IValidate<TEntityDTO>
        where TEntityRepositry : IRepository<TEntity>
        where TEntityMapping : IMapping<TEntity, TEntityDTO>

    {
        private bool _isNewEntity;
        private TEntity _entityPoco;
        private readonly Lazy<TEntityRepositry> _entityRepositry;
        private readonly Lazy<TEntityMapping> _entityeMapping;
        private readonly Lazy<TEntityValidating> _entityeValidating;
        private readonly Lazy<IServiceBuildException> _serviceBuildException;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly IMapper _mapper;
        private readonly Lazy<ICacheProvider> _cacheProvider;

        public EntityUpdateService(Lazy<TEntityRepositry> entityRepositry ,
                                    Lazy<TEntityValidating> entityValidating , 
                                    Lazy<TEntityMapping> entityMapping,
                                    Lazy<IServiceBuildException> serviceBuildException,
                                    Lazy<ISystemServiceProvider> systemServiceProvider,
                                    Lazy<ICommonServices> commonServices,
                                    IMapper mapper,
                                    Lazy<ICacheProvider> cacheProvider)
        {
            
            _entityRepositry = entityRepositry;
            _entityeMapping = entityMapping;
            _entityeValidating = entityValidating;
            _serviceBuildException = serviceBuildException;
            _systemServiceProvider = systemServiceProvider;
            _commonServices = commonServices;
            _mapper = mapper;
            _cacheProvider = cacheProvider;
        }

        public virtual async Task<TEntityDTO> CreateAsync(TEntityDTO entityDTO)
        {
            _isNewEntity = true;
            _entityPoco = (TEntity)Activator.CreateInstance(typeof(TEntity)); 
            this._entityeValidating.Value.Validate(entityDTO, _isNewEntity);
            _entityPoco = this._entityeMapping.Value.MapEntity(_entityPoco, entityDTO, _isNewEntity);
            this._entityRepositry.Value.AddAsync(_entityPoco);
            await this._entityRepositry.Value.SaveChangesAsync();

            return this._mapper.Map<TEntityDTO>(_entityPoco);
        }

        public virtual async Task<TEntityDTO> UpdateAsync(TEntityDTO entityDTO, params object[] keyValues)
        { 
            _isNewEntity = false;
            _entityPoco = await _entityRepositry.Value.FindAsync(keyValues);
            if (_entityPoco != null)
            {
                this._entityeValidating.Value.Validate(entityDTO, _isNewEntity);
                _entityPoco = this._entityeMapping.Value.MapEntity(_entityPoco, entityDTO, _isNewEntity);
                this._entityRepositry.Value.Update(_entityPoco);
                await this._entityRepositry.Value.SaveChangesAsync();
                return this._mapper.Map<TEntityDTO>(_entityPoco); ;
            }
            else
            {
                return default(TEntityDTO);
            }
        }

        public virtual async Task<TEntityDTO> DeleteAsync(params object[] keyValues)
        {
            _entityPoco = await _entityRepositry.Value.FindAsync(keyValues);
            if (_entityPoco != null)
            {
                this._entityRepositry.Value.Remove(_entityPoco);
                await this._entityRepositry.Value.SaveChangesAsync();
                return this._mapper.Map<TEntityDTO>(_entityPoco);
            }
            else
            {
                return default(TEntityDTO);
            }
        }
    }
}
