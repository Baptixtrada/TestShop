namespace TestShop.Application.Orders.Queries.GetOrderDetail
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public required string CustomerName { get; set; }
        public required string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}