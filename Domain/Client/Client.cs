using TestShop.Domain.Common;

namespace TestShop.Domain.Client{

    public class Client : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}