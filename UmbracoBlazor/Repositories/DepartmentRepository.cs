using UmbracoBlazor.Models;
using UmbracoBlazor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmbracoBlazor.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int Id);
    }
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;

        public DepartmentRepository(AppDbContext dbContext)
        {
            this.appDbContext = dbContext;
        }
        public async Task<Department> GetDepartment(int Id)
        {
            return await appDbContext.Departments.FirstOrDefaultAsync(d => d.DepartmentId == Id);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await appDbContext.Departments.ToListAsync();
        }
    }
}
