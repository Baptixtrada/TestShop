using TestShop.Application.Customers.Queries.GetCustomerList;

namespace TestShop.Application.Customers.Queries.GetCustomerList
{
    public interface IGetCustomersListQuery
    {
        List<CustomerModel> Execute();
    }
}