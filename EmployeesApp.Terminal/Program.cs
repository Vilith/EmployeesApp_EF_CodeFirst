﻿using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Application.Employees.Services;
using EmployeesApp.Domain.Entities;
using EmployeesApp.Infrastructure.Data;
using EmployeesApp.Infrastructure.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EmployeesApp.Terminal;
internal class Program
{


    static void Main(string[] args)
    {
        // ListAllEmployees();
        // ListEmployee(562);
    }
    /*
    //static readonly EmployeeService employeeService = new(new EmployeeRepository(new EmployeeContext(options: ));
   

    

    private static void ListAllEmployees()
    {
        foreach (var item in employeeService.GetAll())
            Console.WriteLine(item.Name);

        Console.WriteLine("------------------------------");
    }

    private static void ListEmployee(int employeeID)
    {
        Employee? employee;

        try
        {
            employee = employeeService.GetById(employeeID);
            Console.WriteLine($"{employee?.Name}: {employee?.Email}");
            Console.WriteLine("------------------------------");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"EXCEPTION: {e.Message}");
        }
    }

    */
}
