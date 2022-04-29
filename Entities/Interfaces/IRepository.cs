using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        Doctor CreateDoctor(T entity);
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctor(int id);
        Doctor RemoveDoctor(int id);
        Doctor UpdateDoctor(T entity);
    }
}
