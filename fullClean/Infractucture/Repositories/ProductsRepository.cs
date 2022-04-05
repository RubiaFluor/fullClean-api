using System;
using fullClean.Dominio.Interfaces;
using fullClean.Dominio.Models;

namespace fullClean.Infractucture.Repositories
{
    public class ProductsRepository : GeneralRepository<Products>, IProducts

    {
        public ProductsRepository(AppDbContext appDbContext): base(appDbContext)
        {
        }
    }
}
