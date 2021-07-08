using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day02.Employee.MVC.Core.Data
{
    [Table("employee")]
    public partial class EmployeeEntity
    {
        [Key]
        public int EmployeeCode { get; set; }
        public int JobProfileId { get; set; }
        public int EmployeeNumber { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]
        public string PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string AddressLine1 { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string AddressLine2 { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string City { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string PinCode { get; set; }
        [Column(TypeName = "bit(1)")]
        public bool Status { get; set; }
    }
}
