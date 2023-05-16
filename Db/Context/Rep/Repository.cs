using Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Db.Context.Rep
{
    /// <summary>
    /// Класс для использования базы данных
    /// </summary>
    public class Repository : IRepository
    {
        private readonly ProductContext _context;
        public static IRepository Instance { get; } = new Repository();
        public IRepository Context => Repository.Instance;
        private Repository()
        {
            _context = new ProductContext();
        }

        public async Task AddProductAsync(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            await _context.Products.AddAsync(product);
        }

        public async Task AddReportAsync(Report report)
        {
            if(report == null)
            {
                throw new ArgumentNullException(nameof(report));
            }
            await _context.Reports.AddAsync(report);
        }

        public async Task AddStatusAsync(Status status)
        {
            if(status == null)
            {
                throw new ArgumentNullException(nameof(status));
            }
            await _context.Statuts.AddAsync(status);
        }

        public async Task DeleteProductAsync(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            await Task.Run(() => _context.Products.Remove(product));
        }

        public async Task DeleteReportAsync(Report report)
        {
            if (report == null)
            {
                throw new ArgumentNullException(nameof(report));
            }
            await Task.Run(() => _context.Reports.RemoveRange(report));
        }

        public async Task DeleteStatusAsync(Status status)
        {
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status));
            }
            await Task.Run(() => _context.Statuts.Remove(status));
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await Task.Run(() => _context.Products);
        }

        public async Task<IEnumerable<Report>> GetReportsAsync()
        {
            return await Task.Run(() => _context.Reports);
        }

        public async Task<IEnumerable<Status>> GetStatusesAsync()
        {
            return await Task.Run(() => _context.Statuts);
        }

        public async Task PutProductAsync(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException(nameof(Product));
            }
            await Task.Run(() =>
            {
                    var products = _context.Products.ToList();
                
                    var productNew = products.FirstOrDefault(x => x.Id == product.Id);
                    if(!(productNew is null))
                    {
                        productNew = product;
                    }
                
            });
        }

        public async Task PutReportAsync(Report report)
        {
            if(report == null)
            {
                throw new ArgumentNullException(nameof(Report));
            }
            await Task.Run(() =>
            {
                var reports = _context.Reports.ToList();

                var reportNew = reports.FirstOrDefault(x => x.Id == report.Id);
                if (!(reportNew is null))
                {
                    reportNew = report;
                }

            });
        }

        public async Task PutStatusAsync(Status status)
        {
            if (status == null)
            {
                throw new ArgumentNullException(nameof(Report));
            }

            await Task.Run(() =>
            {
                var statuses = _context.Statuts.ToList();

                var statusNew = statuses.FirstOrDefault(x => x.Id == status.Id);
                if (!(statusNew is null))
                {
                    statusNew = status;
                }

            });
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }

    
}
