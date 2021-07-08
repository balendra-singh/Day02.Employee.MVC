using AutoMapper;
using Day02.Employee.MVC.Core.Data;
using Day02.Employee.MVC.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day02.Employee.MVC.Core.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IMapper mapper;
        private readonly EmployeeDbFirstContext employeeDbContext;

        //constructor used DI
        public EmployeeRepository(IMapper mapper, EmployeeDbFirstContext employeeDbContext)
        {
            this.mapper = mapper;
            this.employeeDbContext = employeeDbContext;
        }

        public WebResponseModel<EmployeeModel> AddEmployee(EmployeeModel employeeModel)
        {

            EmployeeEntity employeeEntity = mapper.Map<EmployeeEntity>(employeeModel);

            employeeDbContext.EmployeeEntities.Add(employeeEntity);
            employeeDbContext.SaveChanges();

            return new WebResponseModel<EmployeeModel>
            {
                ErrorMessage = "Record added",
                ResponseData = mapper.Map<EmployeeModel>(employeeEntity)       //Send the updated model with data from db entites with newly created employee code value
            };
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            var employeeRecordList = new List<EmployeeModel>();

            var employeDbRecords = employeeDbContext.EmployeeEntities.AsEnumerable();

            foreach (var item in employeDbRecords)
            {
                employeeRecordList.Add(mapper.Map<EmployeeModel>(item));
            }

            return employeeRecordList;
        }

        public EmployeeModel GetEmployee(int employeeNumber)
        {
            var employeRecord = employeeDbContext.EmployeeEntities.Where(e => e.EmployeeNumber == employeeNumber).FirstOrDefault();
            if (employeRecord is null)
                return null;

            return mapper.Map<EmployeeModel>(employeRecord);

        }

        public WebResponseModel<EmployeeModel> UpdateEmployee(EmployeeModel updatedEmployeeModel)
        {
            var employeRecordToUpdate = employeeDbContext.EmployeeEntities.Where(e => e.EmployeeNumber == updatedEmployeeModel.EmployeeNumber).FirstOrDefault();
            if (employeRecordToUpdate is null)
                return new WebResponseModel<EmployeeModel>
                {
                    ErrorMessage = "Record not found",
                };

            employeRecordToUpdate = mapper.Map<EmployeeEntity>(updatedEmployeeModel);
            employeeDbContext.SaveChanges();

            return new WebResponseModel<EmployeeModel>
            {
                ErrorMessage = "Record updated",
                ResponseData = updatedEmployeeModel
            };
        }

        public WebResponseModel<bool> UpdateEmployeeStatus(int employeeNumber, EmployeeStatusEnum employeeStatusEnum)
        {
            var employeRecordToUpdate = employeeDbContext.EmployeeEntities.Where(e => e.EmployeeNumber == employeeNumber).FirstOrDefault();

            if (employeRecordToUpdate is null)
                return new WebResponseModel<bool>
                {
                    ErrorMessage = "Record not found",
                };

            switch (employeeStatusEnum)
            {
                case EmployeeStatusEnum.Active:
                    employeRecordToUpdate.Status = true;
                    break;
                case EmployeeStatusEnum.Inactive:
                    employeRecordToUpdate.Status = false;
                    break;
            }

            employeeDbContext.SaveChanges();

            return new WebResponseModel<bool>
            {
                ErrorMessage = "Record updated",
            };
        }

        public bool IsEmployeeNumberPresent(int employeeNumber)
        {
            return employeeDbContext.EmployeeEntities.Where(e => e.EmployeeNumber == employeeNumber).Any();
        }
    }
}
