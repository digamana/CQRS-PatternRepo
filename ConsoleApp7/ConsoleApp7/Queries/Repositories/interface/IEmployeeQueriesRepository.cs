using ConsoleApp7.DTOs.Model;

namespace ConsoleApp7.Queries.Repositories.@interface
{
    public interface IEmployeeQueriesRepository
    {
        public Employee FindByID(int employeeID);
        Task<IEnumerable<dynamic>> GetEmployeeAsync1();
        Task<IEnumerable<Employee>> GetEmployeeAsync2();
    }
}
