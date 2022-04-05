using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fullClean.Dominio.Interfaces
{
    public interface IGeneralRepository<T> where T: class
    {
        Task<T> GetT(int id, string properties = null);
        Task AddT(T model);
        Task<IEnumerable<T>> GetAll();
    }
}
