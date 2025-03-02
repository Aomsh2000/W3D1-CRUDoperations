using Microsoft.EntityFrameworkCore;
using CRUDoperations.Models;  // Make sure to reference the correct namespace for your models

namespace CRUDoperations.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor for dependency injection
          public static void SeedData(AppDbContext context)
    {
        if (!context.Employees.Any())
        {
            context.Employees.Add(new Employee
            {
                Name = "John Doe",
                Position = "Manager",
                Salary = 50000
            });

            context.SaveChanges();
        }
    }

    // Make sure to call the seed method after the database is created
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        SeedData(this);
    }
       

        // DbSet representing the Employees table
        public DbSet<Employee> Employees { get; set; }

        
    }
}
