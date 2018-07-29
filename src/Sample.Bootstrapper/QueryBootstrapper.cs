using Microsoft.Extensions.DependencyInjection;
using Sample.Queries;
using Sample.Queries.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Bootstrapper
{
    public static class QueryBootstrapper
    {
        public static IServiceCollection AddQueryServices(this IServiceCollection source)
        {
            source.AddScoped<CustomerByIdQueryHandler>();

            return source;
        }
    }
}
