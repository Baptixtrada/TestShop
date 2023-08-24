using System.Data.Entity.ModelConfiguration;
using TestShop.Domain.Orders;

namespace TestShop.Persistence.Orders
{
    public class OrderConfiguration
           : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Date)
                .IsRequired();

            HasRequired(p => p.Customer);

            HasRequired(p => p.Product);
            HasRequired(p=> p.Payment);

            Property(p => p.TotalPrice)
                .IsRequired()
                .HasPrecision(5, 2);
        }
    }
}