using Sample.BLLayer.BLUtilities.Abstractions;
using Sample.BLLayer.EntityDTOs;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.UpdateServices.Interfaces;
using System.Threading.Tasks;
using AutoMapper;
using Sample.BLLayer.Mapping.Interfaces;
using Sample.DataLayer.Data.Repositries.Interfaces;
using Sample.BLLayer.Validating.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using System;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;

namespace Sample.BLLayer.UpdateServices
{
    public class UserUpdateService : EntityUpdateService<User, IUserRepositry, UserDTO, IUserMapping, IUserValidating, long>, IUserUpdateService
    {
        private Lazy<IUserMapping> _entityMapping;
        private Lazy<IUserValidating> _entityValidating;
        private readonly Lazy<IUserRepositry> _entityRepositry;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly Lazy<IServiceBuildException> _serviceBuildException;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;
        private readonly Lazy<ICacheProvider> _cacheProvider;

        public UserUpdateService(Lazy<IUserRepositry> entityRepositry,
                                 Lazy<IUserValidating> entityValidating,
                                 Lazy<IUserMapping> entityMapping,
                                 Lazy<IServiceBuildException> serviceBuildException,
                                 Lazy<ISystemServiceProvider> systemServiceProvider,
                                 Lazy<ICommonServices> commonServices,
                                 IMapper mapper,
                                 Lazy<ICacheProvider> cacheProvider) :
            base(entityRepositry, entityValidating, entityMapping, serviceBuildException, systemServiceProvider, commonServices, mapper, cacheProvider)
        {
            _entityRepositry = entityRepositry;
            _entityValidating = entityValidating;
            _entityMapping = entityMapping;
            _serviceBuildException = serviceBuildException;
            _systemServiceProvider = systemServiceProvider;
            _commonServices = commonServices;
            _mapper = mapper;
            _cacheProvider = cacheProvider;
        }
 

        public async Task AddToRoleAsync(string userId, string role)
        {
            User user = await _entityRepositry.Value.FindAsync(userId);
            await _entityRepositry.Value.AddToRoleAsync(user, role);

        }

        public async Task SetLockoutEnabledAsync(string userId, bool enabled)
        {
            User user = await _entityRepositry.Value.FindAsync(userId);
            await _entityRepositry.Value.SetLockoutEnabledAsync(user, enabled);

        }


        public async Task UpdatePasswordAsync(string userId, string currentPassword, string newPassword)
        {
            User user = await _entityRepositry.Value.FindAsync(userId);
            await _entityRepositry.Value.UpdatePasswordAsync(user, currentPassword, newPassword);

        }


        public async Task RemoveFromRoleAsync(string userId, string role)
        {
            User user = await _entityRepositry.Value.FindAsync(userId);
            await _entityRepositry.Value.RemoveFromRoleAsync(user, role);

        }

        public async Task<UserDTO> CustomUpdateAsync(UserDTO entityDTO)
        {
            bool  isNewEntity = false;
            _entityValidating.Value.Validate(entityDTO, isNewEntity);
            User entityPoco = await _entityRepositry.Value.FindAsync(entityDTO.Id);
            entityPoco = _entityMapping.Value.MapEntity(entityPoco, entityDTO, isNewEntity);
            await _entityRepositry.Value.UpdateAsync(entityPoco);

            return this._mapper.Map<UserDTO>(entityPoco);
        }

        public async Task<UserDTO> CustomCreateAsync(UserDTO entityDTO, string password)
        {
            bool isNewEntity = true;
            User entityPoco = new User();
            _entityValidating.Value.Validate(entityDTO, isNewEntity);
            entityPoco = _entityMapping.Value.MapEntity(entityPoco, entityDTO, isNewEntity);
            await _entityRepositry.Value.CreateAsync(entityPoco, password);

            return this._mapper.Map<UserDTO>(entityPoco);
        }
 
    }
}
