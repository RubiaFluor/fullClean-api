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

        public DbSet<Products> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Cart> Cart { get; set; }
    }
}
