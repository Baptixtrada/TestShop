using TestShop.Domain.Customers;
using TestShop.Domain.Orders;
using TestShop.Domain.Products;

namespace TestShop.Application.Orders.Commands.CreateOrder.Factory{
    public interface IOrderFactory{
        Order Create(DateTime date, Customer customer, Product product, int quantity);
        
    }
}