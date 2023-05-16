using Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Db.Context
{
    /// <summary>
    /// подключение к базе данных
    /// </summary>
    internal class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public ProductContext() { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Status> Statuts { get; set; }
        public DbSet<Report> Reports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Database=productdb;" +
                "Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }



    }


    
}
