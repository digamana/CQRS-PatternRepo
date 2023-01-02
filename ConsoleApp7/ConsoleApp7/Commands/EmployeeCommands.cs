using ConsoleApp7.Commands.Repositories.@interface;
using ConsoleApp7.DTOs.Model;

namespace ConsoleApp7.Commands
{
    public class EmployeeCommands : IEmployeeCommands
    {
        private readonly IEmployeeCommandsRespository _respository;
        public EmployeeCommands(IEmployeeCommandsRespository respository)
        {
            _respository = respository;
        }
        public void SaveEmpData(Employee employee)
        {
            _respository.SaveEmployee(employee);
        }
    }
}
