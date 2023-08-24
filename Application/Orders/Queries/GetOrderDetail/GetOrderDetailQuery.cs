using TestShop.Application.Interfaces;

namespace TestShop.Application.Orders.Queries.GetOrderDetail
{
    public class GetOrderDetailQuery : IGetOrderDetailQuery
    {
        private readonly IDatabaseService _database;
        public GetOrderDetailQuery(IDatabaseService database)
        {
            _database = database;
        }
        public OrderDetailModel Execute(int orderId)
        {
            var order = _database.Orders.Where(p => p.Id == orderId).Select(p => new OrderDetailModel()
            {
                Id = p.Id,
                Date = p.Date,
                CustomerName = p.Customer!.Name!,
                ProductName = p.Product!.Name,
                UnitPrice = p.UnitPrice,
                Quantity = p.Quantity,
                TotalPrice = p.TotalPrice
            }).Single();
            return order;
        }
    }
}