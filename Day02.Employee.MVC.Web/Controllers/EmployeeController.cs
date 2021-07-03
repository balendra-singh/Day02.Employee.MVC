using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day02.Employee.MVC.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult ManageEmployees()
        {
            return View();
        }
    }
}
