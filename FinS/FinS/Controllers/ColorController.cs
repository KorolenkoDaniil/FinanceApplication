using FinS.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinS.Controllers
{
    public class ColorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ColorRepository colorRepository = new ColorRepository();

        [HttpPost]
        public ColorClass GetColor(int id)
        {
            Console.WriteLine(id);
            return colorRepository.SearchById(id);
        }
    }
}
