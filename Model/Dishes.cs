using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Праткическая_49_Тепляков.Model
{
    /// <summary>
    /// Блюда
    /// </summary>
    public class Dishes
    {
        /// <summary>
        /// Идентификатор блюда
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Категория
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Название блюда
        /// </summary>
        public string NameDish { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// Изображение
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// Версия
        /// </summary>
        public int Version { get; set; }
    }
}
