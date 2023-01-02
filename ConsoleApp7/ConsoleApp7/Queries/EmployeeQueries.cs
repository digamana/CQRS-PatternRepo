using ConsoleApp7.DTOs;
using ConsoleApp7.Queries.Repositories.@interface;

namespace ConsoleApp7.Queries
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
