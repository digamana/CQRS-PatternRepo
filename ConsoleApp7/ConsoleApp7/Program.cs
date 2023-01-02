// See https://aka.ms/new-console-template for more information
using ConsoleApp7;
using ConsoleApp7.Commands.Repositories;
using ConsoleApp7.Queries;
using ConsoleApp7.Queries.Repositories;

Console.WriteLine("Hello, World!");
var empCommand = new EmployeeCommandsRespository();
var empQuery = new EmployeeQueries(new EmployeeQueriesRepository());
var emp = empQuery.GetByID(100);

var employeeCommand = new EmployeeCommandsRespository();

Console.WriteLine($"emp: {emp.Id}");