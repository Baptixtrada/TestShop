using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using TestShop.Domain.Products;

namespace TestShop.Persistence.Products{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>{
        public ProductConfiguration(){
            HasKey(p=> p.Id);
            Property(p=> p.Name).IsRequired().HasMaxLength(50);
            Property(p=> p.Price).IsRequired().HasPrecision(5, 2);
        }
    }
}