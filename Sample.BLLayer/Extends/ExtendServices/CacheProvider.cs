using Sample.BLLayer.Extends.ExtendServices.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace Sample.BLLayer.Extends.ExtendServices
{
    public class CacheProvider : ICacheProvider
    {
        private readonly IMemoryCache _memoryCache;
        public CacheProvider(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public TResult GetCache<TResult>(string key)
        {
            _memoryCache.TryGetValue(key, out TResult value);
            return value;
        }

        public void SetCache<TValue>(string key, TValue value)
        {
            var cacheExpiryOptions = new MemoryCacheEntryOptions
            {
                //AbsoluteExpiration = DateTime.Now.AddMinutes(5),
                Priority = CacheItemPriority.NeverRemove,
                //SlidingExpiration = TimeSpan.FromMinutes(2),
                //Size = 1024,
            };
            _memoryCache.Set(key, value, cacheExpiryOptions);
        }
    }
}
