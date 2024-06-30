using Microsoft.EntityFrameworkCore;
using ZombieParty.Models;
using ZombieParty.Models.Data;
using System.Linq;
using System.Linq.Expressions;

namespace ZombieParty.Services
{
    public class ZombieService : ServiceBaseAsync<Zombie>, IZombieService
    {
        public ZombieService(ZombiePartyDbContext dbContext) : base(dbContext)
        {
         
        }

        public async Task<List<Zombie>> GetAllByZombieTypeAsync(int zombieTypeId)
        {
            var zombies = await _dbContext.Zombies.Where(x => x.ZombieTypeId == zombieTypeId).ToListAsync();
            return zombies;
        }

        public async Task<IReadOnlyList<Zombie>> GetAllIndexAsync()
        {
            return await _dbContext.Set<Zombie>().OrderBy(z => z.Name).Include(z => z.ZombieType).ToListAsync();
        }

        bool IZombieService.ZombieNameExist(string name)
        {
            var ZombieSameName = _dbContext.Zombies.Where(x => x.Name == name).Any();
            return ZombieSameName;
        }
    }
}
