using Day02.Employee.MVC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day02.Employee.MVC.Core.Repository
{
    public interface IEmployeeRepository
    {
        //create
        //update
        //delete
        //read-all
        //read-by-id
        WebResponseModel<EmployeeModel> AddEmployee(EmployeeModel employeeModel);
        WebResponseModel<EmployeeModel> UpdateEmployee(EmployeeModel updatedEmployeeModel);
        WebResponseModel<bool> UpdateEmployeeStatus(int employeeNumber, EmployeeStatusEnum employeeStatusEnum);
        List<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployee(int employeeNumber);
        bool IsEmployeeNumberPresent(int employeeNumber);
    }
}
