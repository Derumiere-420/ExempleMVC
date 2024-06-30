using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZombieParty.Models;
using ZombieParty.Models.Data;
using ZombieParty.Services;
using ZombieParty.Utility;
using ZombieParty.ViewModels;
using System.Linq;

namespace ZombieParty.Controllers
{
    public class ZombieTypeController : Controller
    {
        private IZombieTypeService _serviceZT;
        private IZombieService _serviceZ;

        public ZombieTypeController(IZombieTypeService serviceZT, IZombieService serviceZ)
        {
            _serviceZT = serviceZT;
            _serviceZ = serviceZ;

        }

        public async Task<IActionResult> Index()
        {
            //// Version 1
            //List<ZombieType> zombieTypesList = (List<ZombieType>)await _serviceZT.GetAllAsync();
            //return View(zombieTypesList);

            // Version 2
            return View(await _serviceZT.GetAllAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            var zombies = await _serviceZ.GetAllByZombieTypeAsync(id);

            ZombieTypeVM zombieTypeVM = new()
            {
                ZombieType = new(),
                ZombiesList = zombies,
                ZombiesCount = zombies.Count(),
                PointsAverage = zombies.Average(p => p.Point)
            };

            zombieTypeVM.ZombieType = await _serviceZT.GetByIdAsync(id);
            return View(zombieTypeVM);
        }


        //GET CREATE
        public IActionResult Create()
        {
            //ici pas grand intérêt à la mettre async
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ZombieType zombieType)
        {
            if (ModelState.IsValid)
            {
                // Ajouter à la BD
                await _serviceZT.CreateAsync(zombieType);
                return this.RedirectToAction("Index");
            }

            return View("Create", zombieType);
        }

        public async Task<IActionResult> Edit(int id)
        {
            ZombieType? zombieType = await _serviceZT.GetByIdAsync(id);

            return View("Edit", zombieType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ZombieType zombieType)
        {
            if (ModelState.IsValid)
            {
                await _serviceZT.EditAsync(zombieType);
                return this.RedirectToAction("Index");
            }

            return View("Edit", zombieType);
        }

        public async Task<IActionResult> Delete(int id)
        {
            ZombieType? zombieType = await _serviceZT.GetByIdAsync(id);
            if (zombieType == null)
            {
                return NotFound();
            }

            return View("Delete", zombieType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int id)
        {
            ZombieType? zombieType = await _serviceZT.GetByIdAsync(id);
            if (zombieType == null)
            {
                return NotFound();
            }

            await _serviceZT.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
