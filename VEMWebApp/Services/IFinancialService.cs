using VEMWebApp.Models.Financial;

namespace VEMWebApp.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}
