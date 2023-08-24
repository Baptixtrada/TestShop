namespace TestShop.Application.Orders.Commands.CreateOrder
{
    public class CreateOrderModel
    {
        public int CustomerId { get; set; }

        public int EmployeeId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }        
    }
}
