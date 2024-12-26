using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Management_System.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime DateOfRegister { get; set; }

        public User()
        {
            
        }
        public User(string userName, string userPassword, DateTime dateOfRegistration)
        {
            Username = userName;
            Password = userPassword;
            DateOfRegister = dateOfRegistration;
        }
    }
}
