using Sample.Contracts.Queries;
using Sample.DataAccess;
using Sample.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.Queries.Customers
{
    public class CustomerByIdQueryHandler : IQueryHandler<CustomerByIdQuery, Customer>
    {
        private CustomerStore _store;

        public CustomerByIdQueryHandler(CustomerStore store)
        {
            _store = store;
        }
        public Customer Execute(CustomerByIdQuery query)
        {
            return _store.AsQueryable().FirstOrDefault(query.Exp);
        }
    }
}
