using System;
using System.Collections.Generic;
using System.Text;

namespace Day02.Employee.MVC.Core.Models
{
    public class EmployeeModel
    {
        public int EmployeeCode { get; set; }
        public int EmployeeNumber { get; set; }
        public int JobProfileId { get; set; } //DFault->0   //1

        public string JobProfile
        {
            get
            {
                switch (JobProfileId)
                {
                    case (int)JobProfileEnum.Director: return JobProfileEnum.Director.ToString();
                    case (int)JobProfileEnum.Manager: return JobProfileEnum.Manager.ToString();
                    case (int)JobProfileEnum.Trainee: return JobProfileEnum.Trainee.ToString();

                    default: return "Job profile is unassigned!";
                }
            }
        }

        public string Name { get; set; }


        public DateTime DateOfBirth { get; set; } // 01-01-0001 00:00:000 [MinValue]

        public string DateOfBirthString
        {
            get { return DateOfBirth.ToString("dd-MMM-yyyy"); }
        }

        public string PhoneNumber { get; set; }


        public string AddressLine1 { get; set; }


        public string AddressLine2 { get; set; }

        public string AddressString
        {
            get
            {

                return $"{AddressLine1} {AddressLine2}";
            }
        }

        public string City { get; set; }


        public string PinCode { get; set; } //null


        public bool Status { get; set; } //false
        public string StatusString
        {
            get
            {
                if (Status)
                    return EmployeeStatusEnum.Active.ToString();

                return EmployeeStatusEnum.Inactive.ToString();
            }
        }
    }

    public enum JobProfileEnum
    {
        Director = 1,
        Manager = 2,
        Trainee = 3
    }

    public enum EmployeeStatusEnum
    {
        Inactive = 0,
        Active = 1
    }
}
