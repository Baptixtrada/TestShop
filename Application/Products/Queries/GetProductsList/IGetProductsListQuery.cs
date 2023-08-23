namespace TestShop.Application.Products.Queries.GetProductsList{
    public interface IGetProductsListQuery{
        public List<ProductModel> Execute();
    }
}