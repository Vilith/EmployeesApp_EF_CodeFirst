using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Domain.Entities;

namespace EmployeesApp.Infrastructure.Persistance.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        
        
        public void Add(Employee employee)
        {
            employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        //Classic C# syntax for GetAll()
        public Employee[] GetAll()
        {
            return [.. employees];
        }

        public Employee? GetById(int id) => employees
            .SingleOrDefault(e => e.Id == id);
    }
}