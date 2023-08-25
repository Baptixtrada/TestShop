using TestShop.Domain.Customers;
using TestShop.Domain.Products;
using TestShop.Domain.Orders;
using TestShop.Domain.Payments;
using TestShop.Domain.Shops;

namespace TestShop.Application.Interfaces
{
    public interface IDatabaseService
    {
        ISet<Domain.Customers.Customer> Customers { get; set; }
        ISet<Domain.Orders.Order> Orders { get; set; }
        ISet<Payment> Payments{get;set;}
        ISet<Product> Products { get; set; }
        ISet<Shop> Shops{get;set;}
        void Save();
    }
}