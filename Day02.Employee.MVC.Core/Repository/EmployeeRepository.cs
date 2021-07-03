using Day02.Employee.MVC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day02.Employee.MVC.Core.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public WebResponseModel<EmployeeModel> AddEmployee(EmployeeModel employeeModel)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetEmployee(int employeeNumber)
        {
            throw new NotImplementedException();
        }

        public bool IsEmployeeCodePresent(int employeeNumber)
        {
            throw new NotImplementedException();
        }

        public WebResponseModel<EmployeeModel> UpdateEmployee(EmployeeModel updatedEmployeeModel)
        {
            throw new NotImplementedException();
        }

        public WebResponseModel<bool> UpdateEmployeeStatus(int employeeNumber, EmployeeStatusEnum employeeStatusEnum)
        {
            throw new NotImplementedException();
        }
    }
}
