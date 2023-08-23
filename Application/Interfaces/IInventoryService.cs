namespace TestShop.Application.Interfaces
{
    public interface IInventoryService
    {
        void NotifyOrderOccurred(int productId, int quantity);
    }
}
