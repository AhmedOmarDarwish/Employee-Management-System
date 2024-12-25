using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Models
{
    internal class UserCRUD : IEntityCRUD<User>
    {
        private readonly CompanyDB _companyDB;
        public UserCRUD()
        {
            _companyDB = new CompanyDB();
        }
        public void Delete(int id)
        {
            var deleteUser = GetEntityByID(id);
            if (deleteUser != null)
            {
                _companyDB.Users.Remove(deleteUser);
                _companyDB.SaveChanges();
            }
        }
        public IEnumerable<User> GetAll()
        {
            return _companyDB.Users.ToList();
        }
        public User GetEntityByID(int id)
        {
            User user = _companyDB.Users.Where(u => u.Id == id).FirstOrDefault();
            return user;
        }
        public User GetEntity(string userName, string pasword)
        {
            User user = _companyDB.Users.Where(u => u.Username == userName && u.Password == pasword).FirstOrDefault();
            return user;
        }
        public User GetEntityByuserName(string userName)
        {
            User user = _companyDB.Users.Where(u => u.Username == userName).FirstOrDefault();
            return user;
        }
        public void Insert(User newEntity)
        {
            _companyDB.Users.Add(newEntity);
            _companyDB.SaveChanges();
        }
        public void Update(User newEntity)
        {
            var oldUser = _companyDB.Users.AsNoTracking().FirstOrDefault(u => u.Username == newEntity.Username);
            if (oldUser != null) { 
                _companyDB.Entry(newEntity).State = EntityState.Modified;
                _companyDB.SaveChanges();
            }
        }
    }
}
