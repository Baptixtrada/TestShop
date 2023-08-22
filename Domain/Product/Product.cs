using TestShop.Domain.Common;

namespace TestShop.Domain.Product{

    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}