using Microsoft.Extensions.DependencyInjection;
using Sample.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Bootstrapper
{
    public static class StoreBootstrapper
    {
        public static IServiceCollection AddStoreServices(this IServiceCollection source)
        {
            source.AddSingleton<CustomerStore>();

            return source;
        }
    }
}
