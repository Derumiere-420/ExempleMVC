using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using ZombieParty.Models;
using ZombieParty.Models.Data;
using ZombieParty.Utility;

namespace ZombieParty.Controllers
{
    public class HuntingLogController : Controller
    {
        private ZombiePartyDbContext _baseDonnees { get; set; }

        public HuntingLogController(ZombiePartyDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _baseDonnees.HuntingLogs.ToListAsync());
        }

        //GET
        [Authorize(Roles = AppConstants.HunterRole + "," + AppConstants.AdminRole)]
        public async Task<IActionResult> Upsert(int? id)
        {
            if (id == null || id == 0)
                // create
                return View(new HuntingLog());
            else
                //update
                return View(await _baseDonnees.HuntingLogs.FindAsync(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(HuntingLog huntingLog)
        {
            if (ModelState.IsValid)
            {
                // Create
                if (huntingLog.Id == 0)
                {
                    // Ajouter à la BD
                    await _baseDonnees.HuntingLogs.AddAsync(huntingLog);
                    TempData[AppConstants.Success] = $"{huntingLog.Title} hunting log added";
                }
                else
                {
                    // Update
                    _baseDonnees.HuntingLogs.Update(huntingLog);
                    TempData[AppConstants.Success] = $"{huntingLog.Title} hunting log updated";
                }
                await _baseDonnees.SaveChangesAsync();

                return this.RedirectToAction("Index");
            }

            return this.View(huntingLog);
        }
    }
}
