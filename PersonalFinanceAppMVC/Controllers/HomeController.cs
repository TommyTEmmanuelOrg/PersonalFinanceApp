using Microsoft.AspNetCore.Mvc;
using PersonalFinanceAppMVC.Models;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;

namespace PersonalFinanceAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Tomo() { 
            return View();
        }

        public IActionResult Card()
        {
            var myListOfCards = new List<MyCard>();

            var brownCard = new MyCard()
            {
                CardNumber = 1234567890,
                FullName = "Eugen Deur",
                ExpirationDate = DateTime.Parse("2024-02-23")
            };
            var redCard = new MyCard()
            {
                CardNumber = 1234567891,
                FullName = "Tomislav Tolj 2",
                ExpirationDate = DateTime.Parse("2024-04-23")
            };
            var greenCard = new MyCard()
            {
                CardNumber = 1234567892,
                FullName = "Luka Modri�",
                ExpirationDate = DateTime.Parse("2024-05-23")
            };
            var whiteCard = new MyCard()
            {
                CardNumber = 1234567893,
                FullName = "Albert Einstein",
                ExpirationDate = DateTime.Parse("2024-06-23")
            };
            myListOfCards.Add(brownCard);
            myListOfCards.Add(redCard);
            myListOfCards.Add(greenCard);
            myListOfCards.Add(whiteCard);

            return View(myListOfCards);
        }
        public IActionResult Placanje()
        {
            return View();
        }
        public IActionResult Statistika() {
            return View();
        }
        public IActionResult Izvjesce()
        {
            return View();
        }
        public IActionResult Proracun()
        {
            return View();
        }
        public IActionResult Racun()
        {
            return View();
        }
        public IActionResult Prihod()
        {
            return View();
        }
        public IActionResult Dugovi()
        {
            return View();
        }
        public IActionResult Racuni()
        {
            return View();
        }
        public IActionResult Ulaganja()
        {
            return View();
        }
        public IActionResult Postavke()
        {
            return View();
        }
        public IActionResult Info()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
