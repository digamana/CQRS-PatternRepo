using ConsoleApp7.DTOs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Repositories
{
    public interface IEmployeeQueriesRepository
    {
        public Employee FindByID(int employeeID);
    }
}
