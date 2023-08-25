using TestShop.Domain.Customers;
using TestShop.Domain.Orders;
using TestShop.Domain.Products;

namespace TestShop.Application.Orders.Commands.CreateOrder.Factory{
    public interface IOrderFactory{
        Domain.Orders.Order Create(DateTime date, Domain.Customers.Customer customer, Product product, int quantity);
        
    }
}