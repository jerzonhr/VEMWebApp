using VEMWebApp.Models.Northwind;

namespace VEMWebApp.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>> GetEmployees();
    }
}
