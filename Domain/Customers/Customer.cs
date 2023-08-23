using TestShop.Domain.Common;

namespace TestShop.Domain.Customers{

    public class Customer : IEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}