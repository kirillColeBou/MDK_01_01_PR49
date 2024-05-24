using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Праткическая_49_Тепляков.Context;
using Праткическая_49_Тепляков.Model;

namespace Праткическая_49_Тепляков.Controllers
{
    [Route("api/OrderController")]
    [ApiExplorerSettings(GroupName = "v4")]
    public class OrderController : Controller
    {
        /// <summary>
        /// Отправить заказ
        /// </summary>
        /// <param name="Token">Токен пользователя</param>
        /// <returns>Данный метод преднозначен для отправки заказа</returns>
        /// <response code="200">Заказ принят</response>
        /// <response code="400">Проблема при запросе</response>
        /// <response code="401">Неавторизованный пользователь</response>
        [Route("SingIn")]
        [HttpPost]
        [ProducesResponseType(typeof(Users), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public ActionResult SingIn([FromForm] string Token)
        {
            if (Token == null) return StatusCode(400);
            try
            {
                Order Order = new OrderContext().Order.First(x => x.Email == Email && x.Password == Password && x.Token == Token);
                return Json(User.Token);
            }
            catch
            {
                return StatusCode(401);
            }
        }
        /// <summary>
        /// Получение истории заказов
        /// </summary>
        /// <remarks>Данный метод получает историю заказов, находящийся в базе данных</remarks>
        /// <response code="200">Список успешно получен</response>
        /// <response code="400">Проблемы при запросе</response>
        /// <response code="401">Неавторизованный доступ</response>
        [Route("History")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Order>), 200)]
        [ProducesResponseType(400)]
        public ActionResult History()
        {
            try
            {
                IEnumerable<Order> Order = new OrderContext().Order;
                return Json(Order);
            }
            catch
            {
                return StatusCode(400);
            }
        }
    }
}
