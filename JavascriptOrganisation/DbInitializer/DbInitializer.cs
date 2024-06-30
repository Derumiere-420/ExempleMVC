using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ZombieParty.Models;
using ZombieParty.Models.Data;
using ZombieParty.Utility;

namespace ZombieParty.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ZombiePartyDbContext _db;

        public DbInitializer(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ZombiePartyDbContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }

        public void Initialize()
        {
            // Exécuter les migrations sont effectuées
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex) { }

            // Créer les rôles suivants si aucun rôle ne figure dans la bd
            if (!_roleManager.RoleExistsAsync(AppConstants.AdminRole).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(AppConstants.AdminRole))
                    .GetAwaiter().GetResult();

                _roleManager.CreateAsync(new IdentityRole(AppConstants.HunterRole))
                    .GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(AppConstants.PlayerRole))
                    .GetAwaiter().GetResult();

                // Créer un User pour le rôle Admin
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "VotreNom@ZombieParty.com",
                    Email = "VotreNom@ZombieParty.com",
                    NickName = "Votre surnom",
                    PhoneNumber = "1111111111",
                    EmailConfirmed = true,
                }, "Admin123*").GetAwaiter().GetResult();
                ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "VotreNom@ZombieParty.com");
                _userManager.AddToRoleAsync(user, AppConstants.AdminRole)
                    .GetAwaiter().GetResult();
                // Créer deux Users pour le rôle Chasseur
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "TopChasseur@ZombieParty.com",
                    Email = "TopChasseur@ZombieParty.com",
                    NickName = "Top Chasseur",
                    PhoneNumber = "1111111111",
                    EmailConfirmed = true,
                }, "Chasseur123*").GetAwaiter().GetResult();
                ApplicationUser user2 = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "TopChasseur@ZombieParty.com");
                _userManager.AddToRoleAsync(user2, AppConstants.HunterRole)
                    .GetAwaiter().GetResult();

                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "CrazyChasseur@ZombieParty.com",
                    Email = "CrazyChasseur@ZombieParty.com",
                    NickName = "Crazy Chasseur",
                    PhoneNumber = "1111111111",
                    EmailConfirmed = true,
                }, "Chasseur123*").GetAwaiter().GetResult();
                ApplicationUser user3 = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "CrazyChasseur@ZombieParty.com");
                _userManager.AddToRoleAsync(user3, AppConstants.HunterRole)
                    .GetAwaiter().GetResult();

                // Créer deux Users pour le rôle Joueur
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "SuperJoueur@ZombieParty.com",
                    Email = "SuperJoueur@ZombieParty.com",
                    NickName = "Super Joueur",
                    PhoneNumber = "1111111111",
                    EmailConfirmed = true,
                }, "Joueur123*").GetAwaiter().GetResult();
                ApplicationUser user4 = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "SuperJoueur@ZombieParty.com");
                _userManager.AddToRoleAsync(user4, AppConstants.PlayerRole)
                    .GetAwaiter().GetResult();

                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "JoueurPourri@ZombieParty.com",
                    Email = "JoueurPourri@ZombieParty.com",
                    NickName = "Joueur Pourri",
                    PhoneNumber = "1111111111",
                    EmailConfirmed = true,
                }, "Joueur123*").GetAwaiter().GetResult();
                ApplicationUser user5 = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "JoueurPourri@ZombieParty.com");
                _userManager.AddToRoleAsync(user5, AppConstants.PlayerRole)
                    .GetAwaiter().GetResult();
            }
        }
    }
}


