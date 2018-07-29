using Sample.Contracts.Queries;
using Sample.Entities.Customers;
using System;
using System.Linq.Expressions;

namespace Sample.Queries.Customers
{
    public class CustomerByIdQuery:IExpressionQuery<Customer>
    {
        public CustomerByIdQuery(int id)
        {
            Exp = c => c.Id == id;
        }

        public Expression<Func<Customer, bool>> Exp { get; }
    }
}
