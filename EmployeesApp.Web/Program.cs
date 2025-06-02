using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Infrastructure.Persistance.Repositories;
using EmployeesApp.Application.Employees.Services;
using EmployeesApp.Web.Models;
using EmployeesApp.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeesApp.Web;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        var connString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<EmployeeContext>(o =>
            o.UseSqlServer(connString));

        builder.Services.AddControllersWithViews();
        builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
        builder.Services.AddSingleton<IEmployeeService, EmployeeService>();
        builder.Services.AddScoped<MyLogServiceFilterAttribute>();
        var app = builder.Build();
        app.MapControllers();
        app.Run();
        //testing 123
    }
}