using DevTrackR.ShippingOrders.Core.Entities;

namespace DevTrackR.ShippingOrders.Core.Repositories
{
    public interface IShippingRepository
    {
        Task<List<ShippingOrder>> GetAllAsync();
    }
}
