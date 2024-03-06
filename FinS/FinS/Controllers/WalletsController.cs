using FinS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinS.Controllers
{
    public class WalletsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public WalletRepository Repository = new WalletRepository();

        [HttpPost]
        public async Task<IActionResult> RegisterAWallet([FromBody] Wallet wallet)
        {
            Console.WriteLine(wallet);
            if (Repository.Savewallet(wallet)) return Ok();             
            else return BadRequest(); 
        }

        [HttpPost]
        public async Task<List<Wallet>> GetWallets(string id)
        {
            return Repository.SearchByUserID(int.Parse(id));
        }

    }
}
