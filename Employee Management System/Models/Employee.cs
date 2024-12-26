using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Models
{
    public enum EmployeePosition
    {
        Developer,
        Manager,
        Tester,
        HR,
        Sales
    }
    internal class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string EmployeeId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Gender { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(11)")]
        public string ContactNumber { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public EmployeePosition Position { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Image { get; set; }
        [DefaultValue(0)]
        [Column(TypeName = "decimal(18,2)")]
        public double Salary { get; set; }
        [Required]
        [DefaultValue("Active")]
        [Column(TypeName = "nvarchar(10)")]
        public string Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfInsert { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfUpdate { get; set; }

    }
}
