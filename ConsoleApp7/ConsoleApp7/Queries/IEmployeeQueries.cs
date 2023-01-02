using ConsoleApp7.DTOs;
using ConsoleApp7.DTOs.Model;

namespace ConsoleApp7.Queries
{
    public interface IEmployeeQueries
    {
        EmployeeDTO GetByID(int employeeID);


    }
}
