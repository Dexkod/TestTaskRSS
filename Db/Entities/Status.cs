using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Entities
{
    /// <summary>
    /// Таблица стутасов
    /// </summary>
    public class Status : IEntites
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? AdoptedTime { get; set; }
        public DateTime? WarehouseTime { get; set; }
        public DateTime? SellTime { get; set; }

        public Status() { }

        public Status(string name, DateTime adoptedTime)
        {
            Name = name;
            AdoptedTime = adoptedTime;
        }
    }
}
