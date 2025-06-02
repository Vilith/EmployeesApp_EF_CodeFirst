using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Infrastructure.Persistance.Repositories;
using EmployeesApp.Infrastructure.Data;
using EmployeesApp.Application.Employees.Services;
using EmployeesApp.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesApp.Web;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<IEmployeeService, EmployeeService>();
        builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        
        builder.Services.AddScoped<MyLogServiceFilterAttribute>();
        // builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        var connString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<EmployeeContext>(o =>
            o.UseSqlServer(connString));

        var app = builder.Build();
        app.MapControllers();
        app.Run();
        //testing 123
    }
}