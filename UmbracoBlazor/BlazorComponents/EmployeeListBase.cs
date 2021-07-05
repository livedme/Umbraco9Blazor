
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UmbracoBlazor.Services;
using Microsoft.AspNetCore.Components;
using UmbracoBlazor.Models;

namespace UmbracoBlazor.BlazorComponents
{
    public class EmployeeListBase:ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
          //  LoadEmployees();
            Employees =  (await EmployeeService.GetEmployees()).ToList();
         // await Task.Run(LoadEmployees);
         //  return base.OnInitializedAsync();
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee ei = new()
            {
                Id = 1,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "sam@gmail.com",
                DateOfBrith = new DateTime(1990, 1, 1),
                Gender=Gender.Male,
                DepartmentId=1,
                PhotoPath="images/sam.jpg"
            };

            Employee ei1 = new()
            {
                Id = 2,
                FirstName = "John",
                LastName = "Hoastings",
                Email = "john@gmail.com",
                DateOfBrith = new DateTime(1990, 1, 1),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.jpg"
            };

            Employee ei2 = new()
            {
                Id = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@gmail.com",
                DateOfBrith = new DateTime(1990, 1, 1),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/mary.jpg"
            };

            Employees = new List<Employee>() { ei, ei1, ei2 };
        }
    }
}
