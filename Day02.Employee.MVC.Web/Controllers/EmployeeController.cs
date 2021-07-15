using AutoMapper;
using Day02.Employee.MVC.Core.Models;
using Day02.Employee.MVC.Core.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        [HttpGet]
        public JsonResult GetAllEmployeeList()
        {            
            var employeeList = employeeRepository.GetAllEmployees();
            return Json(employeeList);
        }

        [HttpGet]
        public JsonResult GetEmployee(int employeeNumber)
        {
            if (employeeNumber <= 0)
                return Json(null);

            if (!employeeRepository.IsEmployeeNumberPresent(employeeNumber))
                return Json(new WebResponseModel<bool>
                {
                    IsSuccess = false,
                    ErrorMessage = "Employee details does not exits"
                });

            var employeeDetail = employeeRepository.GetEmployee(employeeNumber);
            return Json(employeeDetail);
        }

        [HttpPost]
        public JsonResult AddEmployee(EmployeeModel employeeModel)
        {
            if (employeeModel is null)
                return Json(new WebResponseModel<bool>
                {
                    IsSuccess = false,
                    ErrorMessage = "Invalid employee details"
                });

            if (employeeRepository.IsEmployeeNumberPresent(employeeModel.EmployeeNumber))
                return Json(new WebResponseModel<bool>
                {
                    IsSuccess = false,
                    ErrorMessage = "Employee number already exits"
                });

            WebResponseModel<EmployeeModel> response;
            response = employeeRepository.AddEmployee(employeeModel);

            return Json(response);
        }

        [HttpPost]
        public JsonResult UpdateEmployee(EmployeeModel employeeModel)
        {
            if (employeeModel is null)
                return Json(new WebResponseModel<bool>
                {
                    IsSuccess = false,
                    ErrorMessage = "Invalid employee details"
                });

            WebResponseModel<EmployeeModel> response;
            response = employeeRepository.UpdateEmployee(employeeModel);

            return Json(response);
        }

        [HttpGet]
        public JsonResult UpdateEmployeeStatus(int employeeNumber, string employeeStatus)
        {
            if (employeeNumber <= 0)
                return Json(new WebResponseModel<bool>
                {
                    IsSuccess = false,
                    ErrorMessage = "Invalid employee number"
                });

            if (!Enum.TryParse<EmployeeStatusEnum>(employeeStatus, out EmployeeStatusEnum employeeStatusEnum))
                return Json(new WebResponseModel<bool>
                {
                    IsSuccess = false,
                    ErrorMessage = "Invalid employee status"
                });

            if (!employeeRepository.IsEmployeeNumberPresent(employeeNumber))
                return Json(new WebResponseModel<bool>
                {
                    IsSuccess = false,
                    ErrorMessage = "Employee details not found"
                });

            WebResponseModel<bool> response = employeeRepository.UpdateEmployeeStatus(employeeNumber, employeeStatusEnum);
            return Json(response);
        }
    }
}
