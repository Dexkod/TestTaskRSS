using Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Context.Rep
{
    public interface IRepository
    {
        IRepository Context { get; }
        Task<IEnumerable<Product>> GetProductsAsync();
        Task AddProductAsync(Product product);
        Task PutProductAsync(Product product);
        Task DeleteProductAsync(Product product);

        Task<IEnumerable<Status>> GetStatusesAsync();
        Task AddStatusAsync(Status status);
        Task PutStatusAsync(Status status);
        Task DeleteStatusAsync(Status status);
        Task<IEnumerable<Report>> GetReportsAsync();
        Task AddReportAsync(Report report);
        Task PutReportAsync(Report report);
        Task DeleteReportAsync(Report report);
        Task SaveChangesAsync();
    }
}
