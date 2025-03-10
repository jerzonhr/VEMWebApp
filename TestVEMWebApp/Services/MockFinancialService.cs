using VEMWebApp.Models.Financial;

namespace VEMWebApp.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            return Task.FromResult<List<BoxOfficeRevenueType>>(new());
        }
    }
}
