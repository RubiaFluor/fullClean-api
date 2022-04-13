using System;
using fullClean.Dominio.Interfaces;
using fullClean.Dominio.Models;

namespace fullClean.Infractucture.Repositories
{
    public class SalesRepository : GeneralRepository<Sales>, ISales
    {
        public SalesRepository(AppDbContext appDbContext) : base(appDbContext) { }
    }
}
