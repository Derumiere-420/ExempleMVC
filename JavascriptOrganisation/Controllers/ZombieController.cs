using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZombieParty.Models;
using ZombieParty.Models.Data;
using ZombieParty.Services;
using ZombieParty.Utility;
using ZombieParty.ViewModels;
using System.Linq;
using System.Linq.Expressions;

namespace ZombieParty.Controllers
{
    public class ZombieController : Controller
    {
        private ZombiePartyDbContext _baseDonnees;
        private IZombieTypeService _serviceZT;
        private IZombieService _serviceZ;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ZombieController(ZombiePartyDbContext baseDonnees, IZombieService serviceZ, IZombieTypeService serviceZT, IWebHostEnvironment webHostEnvironment)
        {
            _baseDonnees = baseDonnees;
            _serviceZT = serviceZT;
            _serviceZ = serviceZ;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            List<Zombie> zombiesList = (List<Zombie>)await _serviceZ.GetAllIndexAsync();
            return View(zombiesList);
        }

        public async Task<IActionResult> Details(int id)
        {
            Zombie zombie = await _serviceZ.GetByIdAsync(id);
            return PartialView("_ZombieDetails", zombie);
        }

        public async Task<IActionResult> StrongestZombies()
        {
            List<Zombie> zombiesList = await _baseDonnees.Zombies.Where(z => z.Point >= 8).OrderBy(z => z.Name).Include(z => z.ZombieType).ToListAsync();

            return View(zombiesList);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Zombie? zombie = await _baseDonnees.Zombies.Include(z => z.ZombieType).FirstOrDefaultAsync(z => z.Id == id);
            if (zombie == null)
            {
                return NotFound();
            }

            return View(zombie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int id)
        {
            Zombie? zombie = await _baseDonnees.Zombies.FindAsync(id);
            if (zombie == null)
            {
                return NotFound();
            }

            _baseDonnees.Zombies.Remove(zombie);
            await _baseDonnees.SaveChangesAsync();
            TempData[AppConstants.Success] = $"Zombie {zombie.Name} terminated";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            ZombieVM zombieVM = new ZombieVM();
            zombieVM.Zombie = await _serviceZ.GetByIdAsync(id);
            zombieVM.ZombieTypeSelectList = (IEnumerable<SelectListItem>?)_serviceZT.ListZombieTypeDisponible();

            return View(zombieVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ZombieVM zombieVM)
        {
            if (_serviceZ.ZombieNameExist(zombieVM.Zombie.Name))
            {
                TempData[AppConstants.Error] = $"Zombie {zombieVM.Zombie.Name} is already exist.";
                return View(zombieVM);
            }
            //Si le modèle est valide le zombie est modifié et nous sommes redirigé vers index.
            if (ModelState.IsValid)
            {
                string webRootPath = _webHostEnvironment.WebRootPath; //Chemin des images de zombies
                var files = HttpContext.Request.Form.Files; //nouvelle image récupérée

                if (files.Count > 0)
                {
                    // Nom fichier généré, unique        
                    string fileName = Guid.NewGuid().ToString();
                    // chemin pour les images du zombie
                    var uploads = Path.Combine(webRootPath, AppConstants.ImagePathZombies);
                    // extraire l'extention du fichier
                    var extenstion = Path.GetExtension(files[0].FileName);

                    // Create un cannal pour transférer le fichier 
                    using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extenstion), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }

                    // Composer le nom du fichier avec son extension qui sera enregister dans la BD
                    // avec le path relatif à partir du Root
                    // sans le path relatif (le path devra être ajouté dans la View)
                    zombieVM.Zombie.Image = fileName + extenstion;
                }
                else
                {
                    zombieVM.Zombie.Image = zombieVM.OldImage;
                }

               await _serviceZ.EditAsync(zombieVM.Zombie);
                TempData[AppConstants.Success] = $"Zombie {zombieVM.Zombie.Name} has been modified";
                return this.RedirectToAction("Index");
            }
            zombieVM.ZombieTypeSelectList = (IEnumerable<SelectListItem>?)_serviceZT.ListZombieTypeDisponible();

            return View(zombieVM);
        }

        public IActionResult Create()
        {
            ZombieVM zombieVM = new ZombieVM();
            zombieVM.ZombieTypeSelectList = (IEnumerable<SelectListItem>?)_serviceZT.ListZombieTypeDisponible();

            return View(zombieVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ZombieVM zombieVM)
        {
            if(_serviceZ.ZombieNameExist(zombieVM.Zombie.Name))
            {
                TempData[AppConstants.Error] = $"Zombie {zombieVM.Zombie.Name} is already exist."; 
                return View(zombieVM);
            }

            //Si le modèle est valide le zombie est ajouté et nous sommes redirigé vers index.
            if (ModelState.IsValid)
            {
                string webRootPath = _webHostEnvironment.WebRootPath; //Chemin des images de zombies
                var files = HttpContext.Request.Form.Files; //nouvelle image récupérée

                if (files.Count > 0)
                {
                    // Nom fichier généré, unique        
                    string fileName = Guid.NewGuid().ToString();
                    // chemin pour les images du zombie
                    var uploads = Path.Combine(webRootPath, AppConstants.ImagePathZombies);
                    // extraire l'extention du fichier
                    var extenstion = Path.GetExtension(files[0].FileName);

                    // Create un cannal pour transférer le fichier 
                    using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extenstion), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }

                    // Composer le nom du fichier avec son extension qui sera enregister dans la BD
                    // avec le path relatif à partir du Root
                    // sans le path relatif (le path devra être ajouté dans la View)
                    zombieVM.Zombie.Image = fileName + extenstion;
                }

                await _serviceZ.CreateAsync(zombieVM.Zombie);
                TempData[AppConstants.Success] = $"Zombie {zombieVM.Zombie.Name} added";
                return this.RedirectToAction("Index");
            }
            zombieVM.ZombieTypeSelectList = (IEnumerable<SelectListItem>?)_serviceZT.ListZombieTypeDisponible();

            return View(zombieVM);
        }

        [HttpGet]
        public async Task<JsonResult> Favorite(int id)
        {
            Zombie? z = await _baseDonnees.Zombies.FindAsync(id);
            if (z != null)
            {
                z.IsFavorite = !z.IsFavorite;
                _baseDonnees.SaveChanges();
                return new JsonResult(z.IsFavorite);
            }
            throw new Exception("Could not find zombie with id: " + id);
        }
    }
}
