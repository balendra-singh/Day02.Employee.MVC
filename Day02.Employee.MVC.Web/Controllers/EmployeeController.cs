using Day02.Employee.MVC.Core.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day02.Employee.MVC.Web.Controllers
{
    public class EmployeeController : Controller
    {        
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;            
        }
                    
        public IActionResult ManageEmployees()
        {                                    
            return View();
        }


        //AJAX calls | JSON object | JsonResult | var vs dynamic keyword
        [HttpGet]
        public JsonResult GetAllEmployees()
        {
            var employeeDetailList = employeeRepository.GetAllEmployees();
            return Json(employeeDetailList);
        }
    }
}
