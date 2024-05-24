using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Праткическая_49_Тепляков.Model;

namespace Праткическая_49_Тепляков.Context
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Order { get; set; }
        /// <summary>
        /// Конструктор контекста
        /// </summary>
        public OrderContext()
        {
            Database.EnsureCreated();
            Order.Load();
        }
        /// <summary>
        /// Переопределяем метод конфигурации
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySql(Config.Config.StrConnect, Config.Config.mySqlServerVersion);
    }
}
