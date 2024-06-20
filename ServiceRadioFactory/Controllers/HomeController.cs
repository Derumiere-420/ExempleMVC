using ServiceRadioFactory.Factories;
using ServiceRadioFactory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ServiceRadioFactory.Services.Interfaces;
using ServiceRadioFactory.Services.Implementations.Radio;

namespace ServiceRadioFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBatteryFactory _batteryFactory;
        private readonly IRadioFactory _radioFactory;
        private static readonly List<Radio> listRadio = new List<Radio>();

        public HomeController(ILogger<HomeController> logger,
                              IBatteryFactory batteryFactory, 
                              IRadioFactory radioFactory)
        {
            _logger = logger;
            _batteryFactory = batteryFactory;
            _radioFactory = radioFactory;

            if (!listRadio.Any())
            {
                InitializeRadios();
            }
           
        }

        private void InitializeRadios()
        {
            // Exemple d'utilisation avec une batterie Lithium
            var lithiumBattery = _batteryFactory.CreateBattery("LithiumBattery");
            var radioWithLithium = (Radio)_radioFactory.CreateRadio("Sony", lithiumBattery);

            // Exemple d'utilisation avec une batterie Nickel-Cadmium
            var nickelCadmiumBattery = _batteryFactory.CreateBattery("NickelCadmiumBattery");
            var radioWithNickelCadmium = (Radio)_radioFactory.CreateRadio("Samsung", nickelCadmiumBattery);

            // Exemple d'utilisation avec une batterie Alcaline
            var alkalineBattery = _batteryFactory.CreateBattery("AlkalineBattery");
            var radioWithAlkaline = (Radio)_radioFactory.CreateRadio("LG", alkalineBattery);

            listRadio.Add(radioWithLithium);
            listRadio.Add(radioWithAlkaline);
            listRadio.Add(radioWithNickelCadmium);
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
