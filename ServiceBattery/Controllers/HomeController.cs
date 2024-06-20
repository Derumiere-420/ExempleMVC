//Projet avec deux factory non generic Battery et Radio
using Microsoft.AspNetCore.Mvc;
using ServiceBatteryFactory.Models;
using ServiceBatteryFactory.Services.Implementations.Radio;
using ServiceBatteryFactory.Services.Interfaces;
using System.Diagnostics;

namespace ServiceBatteryFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBattery _battery;
        private static readonly List<Radio> listRadio = new List<Radio>();

        public HomeController(ILogger<HomeController> logger,
                              IBattery battery)
        {
            _logger = logger;
            _battery = battery;
            
            if (!listRadio.Any())
            {
                InitializeRadios();
            }
           
        }

        private void InitializeRadios()
        {
            // Exemple d'utilisation avec une batterie Lithium
            var radio1 = new Radio(_battery, "Sony");
            var radio2 = new Radio(_battery, "Samsung");
            var radio3 = new Radio(_battery, "LG");

            listRadio.Add(radio1);
            listRadio.Add(radio2);
            listRadio.Add(radio3);
        }

        public IActionResult Index()
        {
            return View(listRadio);
        }

        [HttpPost]
        public IActionResult PowerOn(Radio RadioType)
        {
            Radio radio = listRadio.FirstOrDefault(r => r.RadioName == RadioType.RadioName);
            TempData["PopupMessage"] = $"{radio.TurnOn()}";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult PowerOff(Radio RadioType)
        {
            IRadio radio = listRadio.FirstOrDefault(r => r.RadioName == RadioType.RadioName);
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
