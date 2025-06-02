using EmployeesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EmployeesApp.Web.Data
{
    public class EmployeeContext(DbContextOptions<EmployeeContext> options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Employee>().HasData
                (
                new Employee
                {
                    Id = 562,
                    Name = "Anders Hejlsberg",
                    Email = "Anders.Hejlsberg@outlook.com",
                },
                new Employee
                {
                    Id = 62,
                    Name = "Kathleen Dollard",
                    Email = "k.d@outlook.com",
                },
                new Employee
                {
                    Id = 15662,
                    Name = "Mads Torgersen",
                    Email = "Admin.Torgersen@outlook.com",
                },
                new Employee
                {
                    Id = 52,
                    Name = "Scott Hanselman",
                    Email = "s.h@outlook.com",
                },
                new Employee
                {
                    Id = 563,
                    Name = "Jon Skeet",
                    Email = "j.s@outlook.com",
                }
                );
            
        }
    }
}

