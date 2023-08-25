using TestShop.Domain.Customers;
using TestShop.Domain.Orders;
using TestShop.Domain.Products;

namespace TestShop.Application.Orders.Commands.CreateOrder.Factory{
    public class OrderFactory : IOrderFactory
    {
        public Domain.Orders.Order Create(DateTime date, Domain.Customers.Customer customer, Product product, int quantity)
        {
            var order = new Domain.Orders.Order();
            order.Date = date;
            order.Customer = customer;
            order.UnitPrice = order.Product!.Price;
            order.Quantity = quantity;
            return order;
        }
    }
}