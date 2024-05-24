using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Праткическая_49_Тепляков.Model
{
    /// <summary>
    /// Пользователи
    /// </summary>
    public class Users
    {
        /// <summary>
        /// Код пользователя
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Токен пользователя
        /// </summary>
        public string Token { get; set; }
    }
}
