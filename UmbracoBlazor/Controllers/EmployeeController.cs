using UmbracoBlazor.Models;
using UmbracoBlazor.Repositories;
using UmbracoBlazor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UmbracoBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await employeeRepository.GetEmployees();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            try
            {
                var result = await employeeRepository.GetEmployee(id);
                if (result == null)
                    return NotFound();

                return result;
            }catch (Exception)
            {
                throw;
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<Employee> Post([FromBody] Employee employee)
        {
            return await employeeRepository.AddEmployee(employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<Employee> Put(int id, [FromBody] Employee employee)
        {
            employee.Id = id;
            return await employeeRepository.UpdateEmployee(employee);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            employeeRepository.DeleteEmployee(id);
        }
    }
}
