using TestShop.Application.Interfaces;

namespace TestShop.Infrastructure.Inventory{
    public class InventoryService : IInventoryService
    {
        public void NotifyOrderOccurred(int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}