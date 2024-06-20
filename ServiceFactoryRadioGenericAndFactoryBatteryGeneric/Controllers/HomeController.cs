//Projet Avec 2 factory Battery et Radio les 2 generic
using Microsoft.AspNetCore.Mvc;
using ServiceBatteryAndRadioFactory.Models;
using ServiceBatteryAndRadioFactory.Services.Implementations.Battery;
using ServiceBatteryAndRadioFactory.Services.Implementations.Radio;
using ServiceBatteryAndRadioFactory.Services.Interfaces;
using ServiceFactoryRadioGenericAndFactoryBatteryGeneric.Factories;
using System.Diagnostics;

namespace ServiceBatteryAndRadioFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGenericFactory _genericFactory;
        private static readonly List<Radio> listRadio = new List<Radio>();

        public HomeController(ILogger<HomeController> logger, IGenericFactory genericFactory)
        {
            _logger = logger;
            _genericFactory = genericFactory;

            if (!listRadio.Any())
            {
                InitializeRadios();
            }
        }

        private void InitializeRadios()
        {
            var lithiumBattery = _genericFactory.Create<LithiumBattery>();
            var radioWithLithium = _genericFactory.Create<LG>();
            radioWithLithium.Battery = lithiumBattery;
            radioWithLithium.RadioName = "LG";
            radioWithLithium.IsRadioOn = false;

            var nickelCadmiumBattery = _genericFactory.Create<NickelCadmiumBattery>();
            var radioWithNickelCadmium = _genericFactory.Create<Sony>();
            radioWithNickelCadmium.Battery = nickelCadmiumBattery;
            radioWithNickelCadmium.RadioName = "Sony";
            radioWithNickelCadmium.IsRadioOn= false;

            var alkalineBattery = _genericFactory.Create<AlkalineBattery>();
            var radioWithAlkaline = _genericFactory.Create<Samsung>();
            radioWithAlkaline.Battery = alkalineBattery;
            radioWithAlkaline.RadioName = "Samsung";
            radioWithAlkaline.IsRadioOn = false;

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
