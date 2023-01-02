using ConsoleApp7.DTOs.Model;
using ConsoleApp7.Queries.Repositories.@interface;

namespace ConsoleApp7.Queries.Repositories
{
    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee FindByID(int employeeID)
        {
            return new Employee()
            {
                Id = 100
            };
        }
    }
}
