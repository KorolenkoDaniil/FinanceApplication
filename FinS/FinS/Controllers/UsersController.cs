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

        public UserRepository UserRepository = new UserRepository();

        [HttpPost]
        public async Task<IActionResult> Registration([FromBody] User user)
        {

            try
            {
                Console.WriteLine(user);
                UserRepository.SaveUser(user);
                return Ok("Регистрация прошла успешно!");
            }
            catch (Exception ex)
            {
                return BadRequest("Ошибка при обработке JSON: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetBy()
        {

            
        }
    }
}
