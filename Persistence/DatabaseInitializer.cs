using System.Data.Entity;
using TestShop.Domain.Customers;
using TestShop.Domain.Orders;
using TestShop.Domain.Products;

namespace TestShop.Persistence
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseService>
    {
        protected override void Seed(DatabaseService database)
        {
            base.Seed(database);
            CreateCustomers(database);
            CreateProducts(database);
            CreateOrders(database);
        }
        private void CreateCustomers(DatabaseService database)
        {
            database.Customers.Add(new Customer() { Name = "Baptiste Grosjean" });
            database.Customers.Add(new Customer() { Name = "Timmy Gilissen" };
            database.Customers.Add(new Customer() { Name = "Stijn Compernolle" });
            database.SaveChanges();
        }
        private void CreateProducts(DatabaseService database)
        {
            database.Products.Add(new Product() { Name = "Spaghetti", Price = 5m });

            database.Products.Add(new Product() { Name = "Lasagna", Price = 10m });

            database.Products.Add(new Product() { Name = "Ravioli", Price = 15m });
            database.SaveChanges();

        }
        private void CreateOrders(DatabaseService database)
        {
            var customers = database.Customers.ToList();

            var products = database.Products.ToList();

            database.Orders.Add(new Order()
            {
                Date = DateTime.Now.Date.AddDays(-3),
                Customer = customers[0],
                Product = products[0],
                UnitPrice = 5m,
                Quantity = 1
            });

            database.Orders.Add(new Order()
            {
                Date = DateTime.Now.Date.AddDays(-2),
                Customer = customers[1],
                Product = products[1],
                UnitPrice = 10m,
                Quantity = 2
            });

            database.Orders.Add(new Order()
            {
                Date = DateTime.Now.Date.AddDays(-1),
                Customer = customers[2],
                Product = products[2],
                UnitPrice = 15m,
                Quantity = 3
            });

            database.SaveChanges();
        }
    }
}