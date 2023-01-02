using ConsoleApp7.DTOs.Model;
using ConsoleApp7.Queries.Repositories.@interface;
using Dapper;
using System.Data.SqlClient;

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
        public async Task<IEnumerable<dynamic>> GetEmployeeAsync1()
        {
            using (var connection = new SqlConnection(@""))
            {
                string strQUERY = @"
                SELECT o.[Id] as ordernumber,
                o.[OrderDate] as [date],os.[Name] as [status],
                SUM(oi.units*oi.unitprice) as total
                FROM [ordering].[Orders] o
                LEFT JOIN[ordering].[orderitems] oi ON o.Id = oi.orderid
                LEFT JOIN[ordering].[orderstatus] os on o.OrderStatusId = os.Id
                GROUP BY o.[Id], o.[OrderDate], os.[Name]
                ";
                connection.Open();
                return await connection.QueryAsync<dynamic>(strQUERY);
            }
        }
        public async Task<IEnumerable<Employee>> GetEmployeeAsync2()
        {
            using (var connection = new SqlConnection(@""))
            {
                string strQUERY = @"
                SELECT o.[Id] as ordernumber,
                o.[OrderDate] as [date],os.[Name] as [status],
                SUM(oi.units*oi.unitprice) as total
                FROM [ordering].[Orders] o
                LEFT JOIN[ordering].[orderitems] oi ON o.Id = oi.orderid
                LEFT JOIN[ordering].[orderstatus] os on o.OrderStatusId = os.Id
                GROUP BY o.[Id], o.[OrderDate], os.[Name]
                ";
                connection.Open();
                return await connection.QueryAsync<Employee>(strQUERY);
            }

        }
    }
}
