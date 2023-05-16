using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Context
{
    /// <summary>
    /// Конфигурации  базы данных
    /// </summary>
    internal class ProductContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb");

            return new ProductContext(optionsBuilder.Options);
        }
    }
}
