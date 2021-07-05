using Flowcourier.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flowrunner.Web.BlazorComponents
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();
        
        protected string Coordinate { get; set; }
       
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        
        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }

        //public void Mouse_Move(MouseEventArgs e)
        //{
        //    Coordinate = $"X={e.ClientX} Y={e.ClientY}";
        //}
    }
}
