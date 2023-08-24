using System.Data.Entity;
using TestShop.Application.Interfaces;
using TestShop.Domain.Customers;
using TestShop.Domain.Orders;
using TestShop.Domain.Payments;
using TestShop.Domain.Products;
using TestShop.Domain.Shops;
using TestShop.Persistence.Customers;
using TestShop.Persistence.Orders;
using TestShop.Persistence.Payments;
using TestShop.Persistence.Products;
using TestShop.Persistence.Shops;

namespace TestShop.Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public required ISet<Customer> Customers { get; set; }
        public required ISet<Order> Orders { get; set; }
        public required ISet<Payment> Payments { get; set; }
        public required ISet<Product> Products { get; set; }
        public required ISet<Shop> Shops { get; set; }
        public DatabaseService() : base("TestShop"){
            Database.SetInitializer( new DatabaseInitializer());
        }
        public void Save()
        {
            this.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new PaymentConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ShopConfiguration());
        }
    }
}