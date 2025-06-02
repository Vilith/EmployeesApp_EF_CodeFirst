using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Domain.Entities;
using EmployeesApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeesApp.Infrastructure.Persistance.Repositories
{
    public class EmployeeRepository(EmployeeContext context) : IEmployeeRepository
    {       
        public void Add(Employee employee)
        {
            employee.Id = context.Employees.Count() < 0 ? 1 : context.Employees.Max(e => e.Id) + 1;
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        //Classic C# syntax for GetAll()
        public Employee[] GetAll()
        {
            return [.. context.Employees];
        }

        public Employee? GetById(int id) => context.Employees
            .SingleOrDefault(e => e.Id == id);
    }
}