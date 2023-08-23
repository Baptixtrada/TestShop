using TestShop.Domain.Customers;

namespace TestShop.Persistence.Customers{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration(){
            HasKey(p=> p.Id);
            PropertyAccessors(p=> p.Name).IsRequired().HasMaxLength(50);
        }
    }
}