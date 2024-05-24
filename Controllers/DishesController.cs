using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Праткическая_49_Тепляков.Context;
using Праткическая_49_Тепляков.Model;

namespace Праткическая_49_Тепляков.Controllers
{
    [Route("api/DishesController")]
    [ApiExplorerSettings(GroupName = "v3")]
    public class DishesController : Controller
    {
        /// <summary>
        /// Получение списка версий
        /// </summary>
        /// <param name="Version">Версия блюда</param>
        /// <remarks>Данный метод получает список версий, находящийся в базе данных</remarks>
        /// <response code="200">Список успешно получен</response>
        /// <response code="400">Проблемы при запросе</response>
        [Route("List")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Dishes>), 200)]
        [ProducesResponseType(400)]
        public ActionResult List([FromForm] int Version)
        {
            try
            {
                IEnumerable<Dishes> Dishes = new DishesContext().Dishes.OrderBy(x => x.Version == Version);
                return Json(Dishes);
            }
            catch
            {
                return StatusCode(400);
            }
        }
    }
}
