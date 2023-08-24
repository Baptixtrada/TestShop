using TestShop.Application.Interfaces;

namespace TestShop.Application.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IGetOrdersListQuery
    {
        private readonly IDatabaseService _database;
        public GetOrdersListQuery(IDatabaseService database)
        {
            _database = database;
        }
        public List<OrdersListItemModel> Execute()
        {
            var orders = _database.Orders
                            .Select(p => new OrdersListItemModel()
                            {
                                Id = p.Id,
                                Date = p.Date,
                                CustomerName = p.Customer!.Name!,
                                ProductName = p.Product!.Name,
                                UnitPrice = p.UnitPrice,
                                Quantity = p.Quantity,
                                TotalPrice = p.TotalPrice
                            });

            return orders.ToList();
        }
    }
}