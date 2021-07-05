using UmbracoBlazor.Models;
using UmbracoBlazor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmbracoBlazor.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int Id);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        void DeleteEmployee(int Id);
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;
        public EmployeeRepository(AppDbContext dbContext)
        {
            appDbContext = dbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteEmployee(int Id)
        {
            var result = await appDbContext.Employees.FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                appDbContext.Employees.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployee(int Id)
        {
            return await appDbContext.Employees
                .Include(e=>e.Department)
                .FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDbContext.Employees
                .Include(e => e.Department)
                .ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appDbContext.Employees.FirstOrDefaultAsync(e => e.Id == employee.Id);
            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBrith = employee.DateOfBrith;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;
                await appDbContext.SaveChangesAsync();
            }

            return result;
        }
    }
}
