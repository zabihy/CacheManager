using System;

namespace Sample.Core
{
    public class SampleConfig
    {
        public string RedisCachingConnectionString { get; set; }
        public bool UseRedis { get; set; }
    }
}
