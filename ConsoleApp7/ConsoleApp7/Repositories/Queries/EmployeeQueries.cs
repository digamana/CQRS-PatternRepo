using ConsoleApp7.DTOs;
using ConsoleApp7.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Repositories.Queries
{
    public class EmployeeQueries
    {
        private readonly IEmployeeQueriesRepository _repository;
        public EmployeeQueries(IEmployeeQueriesRepository repository)
        {
            _repository = repository;
        }
        public EmployeeDTO FindByID(int EmpID)
        {
            var no = _repository.FindByID(EmpID);
            return new EmployeeDTO()
            {
                FullName = "t1",
                Id = no.Id,
                LastName = "t2"
            };

        }
    }
}
