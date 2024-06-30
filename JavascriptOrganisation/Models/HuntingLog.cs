using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        public int Id { get; set; }
        [Display(Name = "Title")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "ValidationStringMinMax")]
        public string Title { get; set; }
        [Display(Name = "Description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Display(Name = "Zombies")]
        [ValidateNever]
        public virtual List<Zombie> Zombies { get; set; }
    }
}
