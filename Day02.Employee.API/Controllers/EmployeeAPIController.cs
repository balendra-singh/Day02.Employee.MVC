using Day02.Employee.MVC.Core.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day02.Employee.API.Controllers
{
    [ApiController]    
    public class EmployeeAPIController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeAPIController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }


        [HttpGet]
        [Route("api/v1/getallemployees")]
        public IActionResult GetAllEmployeeList()
        {
            var employeeList = employeeRepository.GetAllEmployees();
            return Ok(employeeList);
        }
    }
}
