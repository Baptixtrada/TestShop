using TestShop.Domain.Common;

namespace TestShop.Domain.Payments
{
    public class Payment : IEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}