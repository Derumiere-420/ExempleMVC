using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZombieParty.Models;

namespace ZombieParty.ViewModels
{
    public class ZombieVM
    {
        // Pour Upsert 1 zombie à la fois
        public Zombie Zombie { get; set; }
        [ValidateNever]
        public string OldImage { get; set; }

        // Pour créer les deux listes déroulantes
        public IEnumerable<SelectListItem>? ZombieTypeSelectList { get; set; }

    }
}
