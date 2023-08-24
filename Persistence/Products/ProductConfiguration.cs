using System.Data.Entity.ModelConfiguration;
using TestShop.Domain.Products;

namespace TestShop.Persistence.Products
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.Price).IsRequired().HasPrecision(5, 2);
            Property(p => p.Stock).IsRequired();
        }
    }
}