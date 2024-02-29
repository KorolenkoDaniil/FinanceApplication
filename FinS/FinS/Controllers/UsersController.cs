using FinS.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinS.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration([FromBody] User user)
        {
            try
            {
                Console.WriteLine(user);

                return Ok("Регистрация прошла успешно!");
            }
            catch (Exception ex)
            {
                return BadRequest("Ошибка при обработке JSON: " + ex.Message);
            }
        }
    }
}
