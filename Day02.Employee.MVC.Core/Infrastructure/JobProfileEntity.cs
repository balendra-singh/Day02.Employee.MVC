using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day02.Employee.MVC.Core.Infrastructure
{
    [Table("jobprofile")]
    public partial class JobProfileEntity
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int JobProfileId { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string JobProfileName { get; set; }
    }
}