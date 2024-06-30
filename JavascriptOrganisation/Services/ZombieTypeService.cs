using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ZombieParty.Models;
using ZombieParty.Models.Data;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZombieParty.ViewModels;

namespace ZombieParty.Services
{
    public class ZombieTypeService : ServiceBaseAsync<ZombieType>, IZombieTypeService
    {
        public ZombieTypeService(ZombiePartyDbContext dbContext) : base(dbContext)
        {
         
        }

        public override async Task DeleteAsync(int id)
        {
            var zombieType = await this.GetByIdAsync(id);
            if (HasAssociatedZombies(id))
            {
                zombieType.IsDisponible = false;
                await this.EditAsync(zombieType);
            }
            else
            { 
            await base.DeleteAsync(id);
            }
        }

        public bool HasAssociatedZombies(int id)
        {
            var associatedZombies =  _dbContext.Zombies.Where(x => x.ZombieTypeId == id).Any();
            return associatedZombies; 
        }

        public IEnumerable<SelectListItem> ListZombieTypeDisponible()
        {
            var zombieTypeDisponibleList = _dbContext.ZombieTypes.Where(zt => zt.IsDisponible==true).Select(t => new SelectListItem
           {
               Text = t.TypeName,
               Value = t.Id.ToString()
           }).OrderBy(t => t.Text);

            return ((IEnumerable<SelectListItem>)zombieTypeDisponibleList);
        }

    }
}
