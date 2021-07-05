using UmbracoBlazor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UmbracoBlazor.Models;

namespace UmbracoBlazor.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>()
                .HasData(new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>()
                .HasData(new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>()
                .HasData(new Department { DepartmentId = 3, DepartmentName = "Account" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "sam@gmail.com",
                DateOfBrith = new DateTime(1990, 1, 1),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/sam.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 2,
                FirstName = "John",
                LastName = "Hoastings",
                Email = "john@gmail.com",
                DateOfBrith = new DateTime(1990, 1, 1),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/john.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@gmail.com",
                DateOfBrith = new DateTime(1990, 1, 1),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/mary.jpg"
            });

        }
    }
}
