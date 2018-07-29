using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Sample.Caching;
using Sample.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Bootstrapper
{
    public static class CacheBootstrapper
    {
        public static IServiceCollection AddCacheServices(this IServiceCollection source)
        {
            bool useRedis = source.BuildServiceProvider().GetService<IOptionsSnapshot<SampleConfig>>().Value.UseRedis;

            source.AddScoped<IRedisConnectionWrapper, RedisConnectionWrapper>();

            source.AddScoped<ICacheManager, PerRequestCacheManager>();

            if(useRedis)
            {
                source.AddScoped<IStaticCacheManager, RedisCacheManager>();
            }
            else
            {
                source.AddScoped<IStaticCacheManager, MemoryCacheManager>();
            }

            return source;
        }
    }
}
