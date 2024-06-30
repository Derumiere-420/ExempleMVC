using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using ZombieParty.Models;
using ZombieParty.Models.Data;
using ZombieParty.Utility;
using ZombieParty.ViewModels;

namespace ZombieParty.Controllers
{
    [Authorize(Roles = AppConstants.AdminRole)]
    public class WeaponController : Controller
    {
        private ZombiePartyDbContext _baseDonnees { get; set; }
        private readonly IStringLocalizer<WeaponController> _localizer;

        public WeaponController(ZombiePartyDbContext baseDonnees, IStringLocalizer<WeaponController> localizer)
        {
            _baseDonnees = baseDonnees;
            _localizer = localizer;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = _localizer["Title"];
            List<Weapon> weapons = await _baseDonnees.Weapons.ToListAsync();
            return View(weapons);
        }

        //GET
        public async Task<IActionResult> Upsert(int? id)
        {
            if (id == null || id == 0)
            { // create
                ViewBag.Title = _localizer["TitleNew"];
                return View(new Weapon());
            }
            else
            {
                //update
                ViewBag.Title = _localizer["TitleEdit"];
                return View(await _baseDonnees.Weapons.FindAsync(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(Weapon weapon)
        {
            if (ModelState.IsValid)
            {
                // Create
                if (weapon.WeaponId == 0)
                {
                    // Ajouter à la BD
                    await _baseDonnees.Weapons.AddAsync(weapon);
                    TempData[AppConstants.Success] = $"{weapon.Name} weapon added";
                }
                else
                {
                    // Update
                    _baseDonnees.Weapons.Update(weapon);
                    TempData[AppConstants.Success] = $"{weapon.Name} weapon updated";
                }
                await _baseDonnees.SaveChangesAsync();

                return this.RedirectToAction("Index");
            }

            return this.View(weapon);
        }
    }
}
