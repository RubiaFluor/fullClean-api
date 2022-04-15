using System;
using System.Threading.Tasks;
using fullClean.Dominio.Models;
using Microsoft.EntityFrameworkCore;

namespace fullClean.Infractucture
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base (options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesAndProducts>().HasKey(x => new { x.Idproducts, x.Idsales });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        //relacion entre ventas y productos
        public DbSet<SalesAndProducts> SalesAndProducts { get; set; }
      

    }
}
