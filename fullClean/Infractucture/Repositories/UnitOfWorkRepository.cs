using System;
using fullClean.Dominio.Interfaces;

namespace fullClean.Infractucture.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public IProducts products { get; private set; }

        public ISales sales {get; private set;}
        public ICart cart { get; private set; }

        public UnitOfWorkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            products = new ProductsRepository(appDbContext);
            sales = new SalesRepository(appDbContext);
            cart = new CartRepository(appDbContext);
        }

        public void saveData()
        {
            _appDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
