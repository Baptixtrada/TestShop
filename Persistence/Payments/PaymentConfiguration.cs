using System.Data.Entity.ModelConfiguration;
using TestShop.Domain.Payments;

namespace TestShop.Persistence.Payments
{
    public class PaymentConfiguration : EntityTypeConfiguration<Payment>
    {
        public PaymentConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}