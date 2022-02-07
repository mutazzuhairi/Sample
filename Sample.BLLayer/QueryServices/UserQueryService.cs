using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Sample.BLLayer.EntityDTOs;
using Sample.BLLayer.EntityViews;
using Sample.DataLayer.Data.Models.Entities;
using Sample.BLLayer.QueryServices.Interfaces;
using Sample.BLLayer.BLUtilities.Abstractions;
using Sample.DataLayer.Data.Repositries.Interfaces;
using Sample.BLLayer.BLUtilities.HelperServices;
using Sample.BLLayer.BLUtilities.HelperServices.Interfaces;
using Sample.DataLayer.DataUtilities.HelperServices.Interfaces;
using Sample.BLLayer.Extends.ExtendServices.Interfaces;

namespace Sample.BLLayer.QueryServices
{
    public class UserQueryService : EntityQueryService<User, IUserRepositry, UserDTO, UserView, long>, IUserQueryService
    {
        
        private readonly Lazy<IUserRepositry> _entityRepositry;
        private readonly Lazy<ICommonServices> _commonServices;
        private readonly Lazy<IUriService> _uriService;
        private readonly Lazy<IPaginationHelper> _paginationHelper;
        private readonly Lazy<ISystemServiceProvider> _systemServiceProvider;
        private readonly IMapper _mapper;
        private readonly Lazy<ICacheProvider> _cacheProvider;
        public UserQueryService(Lazy<IUserRepositry> entityRepositry,
                                Lazy<ICommonServices> commonServices,
                                Lazy<IUriService> uriService,
                                Lazy<IPaginationHelper> paginationHelper,
                                Lazy<ISystemServiceProvider> systemServiceProvider,
                                IMapper mapper,
                                Lazy<ICacheProvider> cacheProvider) :
            base(entityRepositry, uriService, paginationHelper, systemServiceProvider, commonServices, mapper, cacheProvider)
        {

            _entityRepositry = entityRepositry;
            _commonServices = commonServices;
            _uriService = uriService;
            _paginationHelper = paginationHelper;
            _systemServiceProvider = systemServiceProvider;
            _mapper = mapper;
            _cacheProvider = cacheProvider;
        }

        public async Task<User> FindByEmailAsync(string email)
        {
            return await _entityRepositry.Value.FindByEmailAsync(email);
        }

        public async Task<UserDTO> FindUserDTOByEmailAsync(string email)
        {
            User user =  await _entityRepositry.Value.FindByEmailAsync(email);
            return  _mapper.Map<UserDTO>(user);
        }

        public bool IsUserNameAlreadyExist(string userName, long id)
        {
            return _entityRepositry.Value.AsQueryable().Where(s => s.UserName == userName && s.Id != id).Any();
        }

        public async Task<bool> CheckPasswordAsync(User user, string password)
        {
            return await _entityRepositry.Value.CheckPasswordAsync(user, password);
         }
    }
}
