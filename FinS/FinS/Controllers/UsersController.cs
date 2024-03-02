using FinS.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

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
        public async Task<User> Registration([FromBody] User user)
        {

            Console.WriteLine(user);
            user.Id = UserRepository.SaveUser(user);
            Console.WriteLine(user);
            return user;
        }


        [HttpPost]
        public async Task<User> Authorisation(string email, string password)
        {
            return UserRepository.SearchByEmailAndPassword(email, password); ;
        }


    }
}
