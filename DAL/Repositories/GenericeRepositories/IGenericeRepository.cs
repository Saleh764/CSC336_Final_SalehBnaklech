using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.GenericeRepositories
{
    public interface IGenericeRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T GetById(int id);
        T Add(T Pilot);
        T Update(T Pilot);
        bool Delete(int id);
        bool Delete(T Pilot);
    }
}
