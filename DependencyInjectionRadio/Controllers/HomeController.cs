using ExempleDependencyInjectionRadio.Factories;
using ExempleDependencyInjectionRadio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExempleDependencyInjectionRadio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBatteryFactory _batteryFactory;

        public HomeController(ILogger<HomeController> logger, IBatteryFactory batteryFactory)
        {
            _logger = logger;
            _batteryFactory = batteryFactory;
        }

        public IActionResult Index()
        {
            // Exemple d'utilisation avec une batterie Lithium
            var lithiumBattery = _batteryFactory.CreateBattery("Lithium");
            var radioWithLithium = new Radio(lithiumBattery);
            radioWithLithium.TurnOn();
            radioWithLithium.TurnOff();

            // Exemple d'utilisation avec une batterie Nickel-Cadmium
            var nickelCadmiumBattery = _batteryFactory.CreateBattery("NickelCadmium");
            var radioWithNickelCadmium = new Radio(nickelCadmiumBattery);
            radioWithNickelCadmium.TurnOn();
            radioWithNickelCadmium.TurnOff();

            // Exemple d'utilisation avec une batterie Alcaline
            var alkalineBattery = _batteryFactory.CreateBattery("Alkaline");
            var radioWithAlkaline = new Radio(alkalineBattery);
            radioWithAlkaline.TurnOn();
            radioWithAlkaline.TurnOff();
            return View();
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
