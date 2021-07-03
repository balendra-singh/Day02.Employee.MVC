using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day02.Employee.MVC.Core.Data
{
    [Table("jobprofile")]
    public partial class Jobprofile
    {
        [Key]
        public int JobProfileId { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]
        public string JobProfileName { get; set; }
    }
}
