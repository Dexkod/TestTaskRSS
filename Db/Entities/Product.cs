using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Entities
{
    /// <summary>
    /// Таблица для продуктов имеет отношение с таблицой статусом 1 к 1
    /// </summary>
    public class Product : IEntites
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public int StatusId { get; set; }

        public Product() { }
        public Product(string name, string description, int price, int count)
        {
            Name = name;
            Description = description;
            Price = price;
            Count = count;
        }
    }
}
