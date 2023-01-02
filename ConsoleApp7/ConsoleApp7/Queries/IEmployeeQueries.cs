using ConsoleApp7.DTOs.Model;

namespace ConsoleApp7.Queries
{
    public interface IEmployeeQueries
    {
        Employee GetByID(int employeeID);
    }
}
