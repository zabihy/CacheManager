using Sample.Entities.Customers;
using System;
using System.Collections.Generic;

namespace Sample.DataAccess
{
    public class CustomerStore:List<Customer>
    {
        public CustomerStore()
        {
            for (int i = 0; i < 1000; i++)
            {
                this.Add(new Customer
                {
                    Id = i,
                    Name = $"Customer_{i}"
                });
            }
        }
    }
}
