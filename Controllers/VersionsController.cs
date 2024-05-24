using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Праткическая_49_Тепляков.Context;
using Праткическая_49_Тепляков.Model;

namespace Праткическая_49_Тепляков.Controllers
{
    [Route("api/VersionsController")]
    [ApiExplorerSettings(GroupName = "v2")]
    public class VersionsController : Controller
    {
        /// <summary>
        /// Получение списка версий
        /// </summary>
        /// <remarks>Данный метод получает список версий, находящийся в базе данных</remarks>
        /// <response code="200">Список успешно получен</response>
        /// <response code="400">Проблемы при запросе</response>
        [Route("List")]
        [HttpGet]
        [ProducesResponseType(typeof(List<Versions>), 200)]
        [ProducesResponseType(400)]
        public ActionResult List([FromForm] string Token)
        {
            try
            {
                var User = new UsersContext();
                if (User.Users.FirstOrDefault(x => x.Token == Token) == null) return StatusCode(400);
                IEnumerable<Versions> Versions = new VersionsContext().Versions;
                return Json(Versions);
            }
            catch
            {
                return StatusCode(400);
            }
        }
    }
}
