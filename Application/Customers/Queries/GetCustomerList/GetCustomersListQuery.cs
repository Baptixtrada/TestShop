﻿using TestShop.Application.Interfaces;

namespace TestShop.Application.Customers.Queries.GetCustomerList
{
    public class GetCustomersListQuery 
        : IGetCustomersListQuery
    {
        private readonly IDatabaseService _database;

        public GetCustomersListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<CustomerModel> Execute()
        {
            var customers = _database.Customers
                .Select(p => new CustomerModel()
                {
                    Id = p.Id, 
                    Name = p.Name!
                });

            return customers.ToList();
        }
    }
}
