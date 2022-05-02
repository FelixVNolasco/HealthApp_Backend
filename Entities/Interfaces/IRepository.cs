
using Models.Entities;
using System.Collections.Generic;

namespace Models.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        string CreateDoctor(T entity);
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctor(int id);
        bool RemoveDoctor(int id);
        bool UpdateDoctor(T entity);
    }
}
