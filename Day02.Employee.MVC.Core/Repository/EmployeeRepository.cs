using Day02.Employee.MVC.Core.Data;
using Day02.Employee.MVC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day02.Employee.MVC.Core.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbFirstContext dbContext;       

        public EmployeeRepository(EmployeeDbFirstContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public WebResponseModel<EmployeeModel> AddEmployee(EmployeeModel employeeModel)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            if(dbContext is null)
                Console.WriteLine("dbcontext is null");

            return null;
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
