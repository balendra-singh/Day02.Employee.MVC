using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.Employee.MVC.Core.Infrastructure
{
    [Table("employee")]
    public partial class EmployeeEntity
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int EmployeeCode { get; set; }

        [Required]        
        [Column(TypeName = "int(11)")]
        public int JobProfileId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
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

        [Required]
        [Column(TypeName = "bit(1)")]
        public bool Status { get; set; }
    }
}