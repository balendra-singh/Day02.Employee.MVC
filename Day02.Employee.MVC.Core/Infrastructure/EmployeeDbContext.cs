using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day02.Employee.MVC.Core.Infrastructure
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
         : base(options)
        {
        }

        public virtual DbSet<EmployeeEntity> EmployeeEntities { get; set; }
        public virtual DbSet<JobProfileEntity> JobProfileEnties { get; set; }
    }
}
