using Employee_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Data
{
    internal class DataSeeder
    {
        private readonly CompanyDB _context;

        public DataSeeder(CompanyDB context)
        {
            _context = context;
        }

        public void SeedRandomData(int numberOfEmployees)
        {
            var random = new Random();

            // Only add data if there are no employees already
            if (!_context.Employees.Any())
            {
                for (int i = 0; i < numberOfEmployees; i++)
                {
                    var employee = new Employee
                    {
                        EmployeeId = $"EMP{i:D3}",
                        FullName = $"Employee {i}",
                        Gender = random.Next(0, 2) == 0 ? "Male" : "Female",
                        ContactNumber = $"012{random.Next(10000000, 99999999)}",
                        Position = i % 2 == 0 ? EmployeePosition.Manager : EmployeePosition.Developer,
                        Image = $@"C:\Users\3Mr\Pictures\image{i}.jpg",
                        Salary = Math.Round(random.NextDouble() * 10000, 2),
                        Status = i % 3 == 0 ? "Inactive" : "Active",
                        DateOfInsert = DateTime.Now,
                    };

                    _context.Employees.Add(employee);
                }

                _context.SaveChanges();
            }
        }
    }
}
