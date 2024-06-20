﻿//Projet Avec 2 factory Battery et Radio les 2 generic
using ServiceBatteryAndRadioFactory.Factories;
using ServiceBatteryAndRadioFactory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ServiceBatteryAndRadioFactory.Services.Interfaces;
using ServiceBatteryAndRadioFactory.Services.Implementations.Radio;
using ServiceBatteryAndRadioFactory.Services.Implementations.Battery;

namespace ServiceBatteryAndRadioFactory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBatteryFactory<AlkalineBattery> _alkalineBatteryFactory;
        private readonly IBatteryFactory<LithiumBattery> _lithiumBatteryFactory;
        private readonly IBatteryFactory<NickelCadmiumBattery> _nickelCadmiumBatteryFactory;
        private readonly IRadioFactory<Radio> _radioFactory;
        private static readonly List<Radio> listRadio = new List<Radio>();

        public HomeController(ILogger<HomeController> logger,
       IBatteryFactory<AlkalineBattery> alkalineBatteryFactory,
       IBatteryFactory<LithiumBattery> lithiumBatteryFactory,
       IBatteryFactory<NickelCadmiumBattery> nickelCadmiumBatteryFactory)
        {
            _logger = logger;
            _alkalineBatteryFactory = alkalineBatteryFactory;
            _lithiumBatteryFactory = lithiumBatteryFactory;
            _nickelCadmiumBatteryFactory = nickelCadmiumBatteryFactory;

            if (!listRadio.Any())
            {
                InitializeRadios();
            }

        }

        private void InitializeRadios()
        {
            // Exemple d'utilisation avec une batterie Lithium
            var lithiumBattery = _lithiumBatteryFactory.CreateBattery();
            var radioWithLithium = _radioFactory.CreateRadio("Sony", lithiumBattery);

            // Exemple d'utilisation avec une batterie Nickel-Cadmium
            var nickelCadmiumBattery = _nickelCadmiumBatteryFactory.CreateBattery();
            var radioWithNickelCadmium = (Radio)_radioFactory.CreateRadio("Samsung", nickelCadmiumBattery);

            // Exemple d'utilisation avec une batterie Alcaline
            var alkalineBattery = _alkalineBatteryFactory.CreateBattery();
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
