using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        /// <param name="Address">Введенный адрес</param>
        /// <param name="Date">Введенная дата</param>
        /// <param name="DishId">Введенное блюдо</param>
        /// <param name="Count">Введенное количество</param>
        /// <param name="Token">Токен пользователя</param>
        /// <returns>Данный метод предназначен для отправки заказа</returns>
        /// <response code="200">Заказ принят</response>
        /// <response code="400">Проблема при запросе</response>
        /// <response code="401">Неавторизованный пользователь</response>
        [Route("AddOrder")]
        [HttpPost]
        [ProducesResponseType(typeof(Users), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public ActionResult AddOrder([FromForm] string Address, [FromForm] DateTime Date, [FromForm] int DishId, [FromForm] int Count, [FromForm] string Token)
        {
            if (Address == null || Date == null || DishId == 0 || Count == 0 || Token == null) return StatusCode(400);
            try
            {
                var newOrder = new OrderContext();
                var findUserToken = new UsersContext();
                if (newOrder.Order.FirstOrDefault(x => x.Address == Address && x.Date == Date && x.DishId == DishId && x.Count == Count) != null) return StatusCode(400);
                if (findUserToken.Users.FirstOrDefault(x => x.Token == Token) == null) return StatusCode(400, "Такого токена нету!");
                else
                {
                    Order Order = new Order()
                    {
                        Address = Address,
                        Date = Date,
                        DishId = DishId,
                        Count = Count
                    };
                    newOrder.Order.Add(Order);
                    newOrder.SaveChanges();
                    return Json(newOrder);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
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
