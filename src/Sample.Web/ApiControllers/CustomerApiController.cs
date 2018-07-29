using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Caching;
using Sample.Entities.Customers;
using Sample.Queries.Customers;

namespace Sample.Web.ApiControllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerApiController : ControllerBase
    {
        private readonly CustomerByIdQueryHandler _handler;
        private readonly IStaticCacheManager _cacheManager;

        public CustomerApiController(CustomerByIdQueryHandler handler,
            IStaticCacheManager cacheManager)
        {
            _handler = handler;
            _cacheManager = cacheManager;
        }
        [HttpGet("{id}")]
        public Customer GetById(int id) => _cacheManager.Get(id.ToString(), () => _handler.Execute(new CustomerByIdQuery(id)));
    }
}