using TestShop.Domain.Common;
using TestShop.Domain.Customers;

namespace TestShop.Domain.Baskets{
    public class Basket : IEntity
    {
        public int Id { get ; set ; }
        public Customer? Customer { get ; set ; }
    }
}