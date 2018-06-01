using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Caching.Distributed;

namespace coreWebapi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IDistributedCache _distributedCache;

        public ValuesController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
            
            const string key = "message";
            const string message = "hello";

            _distributedCache.SetString(key, message);
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var cachedMessage = _distributedCache.GetString("message");
            return new List<string> { cachedMessage };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            var cachedMessage = _distributedCache.GetString(id);
            return cachedMessage;
        }
    }
}
