using System;
using System.Threading.Tasks;
using fullClean.Dominio.Interfaces;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace fullClean.Infractucture.Repositories
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : class
    {
        protected AppDbContext _appDbContext;
        internal DbSet<T> _dbSet;
        public GeneralRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();
        }

        public async Task AddT(T model)
        {
            await _appDbContext.AddAsync(model);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetT(int id, string properties = null)
        {
            return await _dbSet.FindAsync(id);

        }
    }
}
