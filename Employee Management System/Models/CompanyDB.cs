using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Employee_Management_System.Models
{
    internal class CompanyDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\OMEN;Database=CompanyDB;Integrated Security=True;Trust Server Certificate=True");
            optionsBuilder.UseSqlServer(@"Data Source = OMEN; Initial Catalog = CompanyDB; Integrated Security = True; Trust Server Certificate = True;");
        }
        public DbSet<Employee> Employees { get; set; }//Table Employees
        public DbSet<User> Users { get; set; }//Table User

    }
}
