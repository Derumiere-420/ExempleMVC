using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZombieParty.Data;

namespace ZombieParty.Models.Data
{
    public class ZombiePartyDbContext : IdentityDbContext<IdentityUser>
    {
        public ZombiePartyDbContext(DbContextOptions<ZombiePartyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Générer des données de départ
            modelBuilder.GenerateData();
        }


        public DbSet<Zombie> Zombies { get; set; }
        public DbSet<ZombieType> ZombieTypes { get; set; }
        public DbSet<HuntingLog> HuntingLogs { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
