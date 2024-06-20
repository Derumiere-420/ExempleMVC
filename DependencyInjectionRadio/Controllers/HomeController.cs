//Projet avec seulement la factory de Battery non Generic

using ServiceBatteryFactory.Factories;
using ServiceBatteryFactory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ServiceBatteryFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBatteryFactory _batteryFactory;
        private static readonly List<Radio> listRadio = new List<Radio>();

        public HomeController(ILogger<HomeController> logger, IBatteryFactory batteryFactory)
        {
            _logger = logger;
            _batteryFactory = batteryFactory;

            if (!listRadio.Any())
            {
                InitializeRadios();
            }
           
        }

        private void InitializeRadios()
        {
            // Exemple d'utilisation avec une batterie Lithium
            var lithiumBattery = _batteryFactory.CreateBattery("LithiumBattery");
            var radioWithLithium = new Radio(lithiumBattery, "Sony");

            // Exemple d'utilisation avec une batterie Nickel-Cadmium
            var nickelCadmiumBattery = _batteryFactory.CreateBattery("NickelCadmiumBattery");
            var radioWithNickelCadmium = new Radio(nickelCadmiumBattery, "Samsung");

            // Exemple d'utilisation avec une batterie Alcaline
            var alkalineBattery = _batteryFactory.CreateBattery("AlkalineBattery");
            var radioWithAlkaline = new Radio(alkalineBattery, "LG");

            listRadio.Add(radioWithLithium);
            listRadio.Add(radioWithAlkaline);
            listRadio.Add(radioWithNickelCadmium);
        }

        public IActionResult Index()
        {
            return View(listRadio);
        }

        [HttpPost]
        public IActionResult PowerOn(string RadioName)
        {
            Radio radio = listRadio.FirstOrDefault(r => r.RadioName == RadioName);
            TempData["PopupMessage"] = $"{radio.TurnOn()}";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult PowerOff(string RadioName)
        {
            Radio radio = listRadio.FirstOrDefault(r => r.RadioName == RadioName);
            TempData["PopupMessage"] = $"{radio.TurnOff()}";
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
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
