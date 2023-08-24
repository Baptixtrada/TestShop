namespace TestShop.Application.Orders.Commands.CreateOrder
{
    public interface ICreateOrderCommand
    {
        void Execute(CreateOrderModel model);
    }
}