using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Entities
{
    /// <summary>
    /// Таблица отчет, хранятся продукты с статусом
    /// </summary>
    public class Report : IEntites
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public Report(){}
    }
}
