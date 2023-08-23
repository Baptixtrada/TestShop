using TestShop.Domain.Common;

namespace TestShop.Domain.Shops{

public class Shop : IEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}