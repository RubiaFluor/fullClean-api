using System;
using fullClean.Dominio.Interfaces;
using fullClean.Dominio.Models;

namespace fullClean.Infractucture.Repositories
{
    public class CartRepository: GeneralRepository<Cart>, ICart
    {
        public CartRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
