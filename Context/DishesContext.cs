using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Праткическая_49_Тепляков.Model;

namespace Праткическая_49_Тепляков.Context
{
    public class DishesContext : DbContext
    {
        public DbSet<Dishes> Dishes { get; set; }
        /// <summary>
        /// Конструктор контекста
        /// </summary>
        public DishesContext()
        {
            Database.EnsureCreated();
            Dishes.Load();
        }
        /// <summary>
        /// Переопределяем метод конфигурации
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySql(Config.Config.StrConnect, Config.Config.mySqlServerVersion);
    }
}
