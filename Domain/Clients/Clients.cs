using TestShop.Domain.Common;

namespace TestShop.Domain.Clients{

    public class Client : IEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}