using VEMWebApp.Models.Northwind;

namespace VEMWebApp.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<OrdersType>> GetOrders()
        {
            return Task.FromResult<List<OrdersType>>(new());
        }
    }
}
