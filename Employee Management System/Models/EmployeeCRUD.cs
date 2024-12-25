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

        public IEnumerable<Employee> GetAll()
        {
           return _CompanyDB.Employees.ToList();
        }

        public Employee GetEntityByID(int id)
        {
            return _CompanyDB.Employees.Where(emp => emp.ID == id).FirstOrDefault();
        }

        public void Insert(Employee newEntity)
        {
            _CompanyDB.Employees.Add(newEntity);
        }

        public void Update(Employee newEntity)
        {
            var oldUser = _CompanyDB.Employees.AsNoTracking().FirstOrDefault(u => u.ID == newEntity.ID);
            if (oldUser != null) { 
            _CompanyDB.Entry(newEntity).State = EntityState.Modified;
            _CompanyDB.SaveChanges();
            }
        }

        public int CountEmployees()
        {
            return _CompanyDB.Employees.Count();
        }
        public int CountActiveEmployees()
        {
            return _CompanyDB.Employees.Where(e => e.Status == "Active").Count();
        }

        public int CountInctiveEmployees()
        {
            return _CompanyDB.Employees.Where(e => e.Status == "Inactive").Count();
        }
    }
}
