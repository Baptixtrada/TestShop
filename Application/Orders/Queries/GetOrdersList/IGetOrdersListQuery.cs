namespace TestShop.Application.Orders.Queries.GetOrdersList{
    public interface IGetOrdersListQuery{
        List<OrdersListItemModel> Execute();
    }
}