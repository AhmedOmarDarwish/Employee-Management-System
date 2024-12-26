using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_System.Models
{
    internal class EmployeeCRUD : IEntityCRUD<Employee>
    {
        private readonly CompanyDB _CompanyDB;
        public EmployeeCRUD()
        {
            _CompanyDB = new CompanyDB();
        }
        public void Delete(int id)
        {
            var oldEmployee = GetEntityByID(id);
            if (oldEmployee != null) { 
            _CompanyDB.Employees.Remove(oldEmployee);
                _CompanyDB.SaveChanges();

            }
        }
        public void DeleteByEmpID(string empid)
        {
            var oldEmployee = GetEmployeeByEmpID(empid);
            if (oldEmployee != null)
            {
                _CompanyDB.Employees.Remove(oldEmployee);
                _CompanyDB.SaveChanges();

            }
        }
        public IEnumerable<Employee> GetAll()
        {
           return _CompanyDB.Employees.ToList();
        }
        public Employee GetEntityByID(int id)
        {
            return _CompanyDB.Employees.Where(emp => emp.ID == id).FirstOrDefault();
        }

        public Employee? GetEmployeeByEmpID(string empId)
        {
            return _CompanyDB.Employees.Where(emp => emp.EmployeeId == empId).FirstOrDefault();
        }

        public void Insert(Employee newEntity)
        {
            _CompanyDB.Employees.Add(newEntity);
            _CompanyDB.SaveChanges();
        }

        public void Update(Employee newEntity)
        {
            //var oldUser = _CompanyDB.Employees.AsNoTracking().FirstOrDefault(u => u.EmployeeId == newEntity.EmployeeId);
            //if (oldUser != null) {
            //    _CompanyDB.Entry(newEntity).State = EntityState.Modified;
            //    _CompanyDB.SaveChanges();
            //}

            var oldEmp = GetEmployeeByEmpID(newEntity.EmployeeId);
            if (oldEmp != null) { 

                oldEmp.FullName = newEntity.FullName;
                oldEmp.ContactNumber = newEntity.ContactNumber;
                oldEmp.Status = newEntity.Status;
                oldEmp.Gender = newEntity.Gender;
                oldEmp.DateOfUpdate = newEntity.DateOfUpdate;
                oldEmp.Position = newEntity.Position;
                oldEmp.Image = newEntity.Image;
                oldEmp.Salary = newEntity.Salary;
                
            }


            _CompanyDB.SaveChanges();
        }
        public void UpdateSalary(Employee newEntity)
        {
            var oldEmp = GetEmployeeByEmpID(newEntity.EmployeeId);
            if (oldEmp != null)
            {

                oldEmp.FullName = newEntity.FullName;
                oldEmp.DateOfUpdate = newEntity.DateOfUpdate;
                oldEmp.Salary = newEntity.Salary;

            }
            _CompanyDB.SaveChanges();
        }
        public int CountEmployees()
        {
            return _CompanyDB.Employees.Count();
        }
        public int CountActiveEmployees()
        {
            return _CompanyDB.Employees.Where(e => e.Status == "Active").Count();
        }
        public IEnumerable<Employee> GetActiveEmployees()
        {
            return _CompanyDB.Employees.Where(e => e.Status == "Active").ToList();
        }

        public int CountInctiveEmployees()
        {
            return _CompanyDB.Employees.Where(e => e.Status == "Inactive").Count();
        }
    }
}
