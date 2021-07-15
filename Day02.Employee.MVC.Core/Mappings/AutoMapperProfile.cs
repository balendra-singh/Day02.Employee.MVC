using AutoMapper;
using Day02.Employee.MVC.Core.Data;
using Day02.Employee.MVC.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day02.Employee.MVC.Core.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeEntity, EmployeeModel>();            
        }
    }
}
