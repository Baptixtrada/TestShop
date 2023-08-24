using CleanArchitecture.Common.Dates;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TestShop.Application.Interfaces;
using TestShop.Application.Orders.Commands.CreateOrder.Factory;

namespace TestShop.Application.Orders.Commands.CreateOrder{
    public class CreateOrderCommand : ICreateOrderCommand
    {
        private readonly IDateService _dateService;
        private readonly IDatabaseService _database;
        private readonly IOrderFactory _factory;
        private readonly IInventoryService _inventory;
        public CreateOrderCommand(IDateService dateService, IDatabaseService database, IOrderFactory factory, IInventoryService inventory){
            _dateService = dateService;
            _database = database;
            _factory = factory;
            _inventory = inventory;
        }
        public void Execute(CreateOrderModel model)
        {
            var date = _dateService.GetDate();
            var customer = _database.Customers.Single(p=> p.Id == model.CustomerId);
            var product = _database.Products.Single(p=>p.Id == model.ProductId);
            var quantity = model.Quantity;
            var order = _factory.Create(date,customer,product,quantity);
            _database.Orders.Add(order);
            _database.Save();
            _inventory.NotifyOrderOccurred(product.Id, quantity);
        }
    }
}