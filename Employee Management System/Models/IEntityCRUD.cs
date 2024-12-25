using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System.Models
{
    internal interface IEntityCRUD<T>
    {
         void Insert(T newEntity);
         void Update(T newEntity);
         void Delete(int id);
         IEnumerable<T> GetAll();
         T GetEntityByID(int id);
    }
}
