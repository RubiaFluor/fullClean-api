using fullClean.Dominio.Models;
using Microsoft.EntityFrameworkCore;

namespace fullClean.Infractucture
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base (options)
        {
        }

        //Api fluent
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<SalesAndProductsModel>().HasKey(x => new { x.ProductsId, x.SalesId });

           base.OnModelCreating(modelBuilder);
        }
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<SaleModel> Sale { get; set; }
        //relacion entre ventas y productos
        public DbSet<SalesAndProductsModel> SalesAndProducts { get; set; }
      

    }
}
