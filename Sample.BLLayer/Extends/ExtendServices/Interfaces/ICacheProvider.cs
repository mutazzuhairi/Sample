using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BLLayer.Extends.ExtendServices.Interfaces
{
    public interface ICacheProvider 
    {
        public TResult GetCache<TResult>(string key);
        public void SetCache<TValue>(string key, TValue value);
    }
}
