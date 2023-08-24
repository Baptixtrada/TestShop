namespace TestShop.Application.Orders.Queries.GetOrderDetail{
    public interface IGetOrderDetailQuery{
        OrderDetailModel Execute(int orderId);
    }
}