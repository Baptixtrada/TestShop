using System.Data.Entity.ModelConfiguration;
using TestShop.Domain.Shops;

namespace TestShop.Persistence.Shops
{
    public class ShopConfiguration : EntityTypeConfiguration<Shop>
    {
        public ShopConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}