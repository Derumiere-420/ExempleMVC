using Microsoft.AspNetCore.Mvc.Rendering;
using ZombieParty.Models;

namespace ZombieParty.Services
{
    public interface IZombieTypeService :IServiceBaseAsync<ZombieType>
    {
        new Task  DeleteAsync(int id);
        bool HasAssociatedZombies(int id);

        IEnumerable<SelectListItem> ListZombieTypeDisponible();
    }
}
