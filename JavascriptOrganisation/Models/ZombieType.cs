using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        public int Id { get; set; }

        [DisplayName("TypeName")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "ValidationStringMinMax")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string TypeName { get; set; }

        [DisplayName("Point")]
        [Range(2, 5, ErrorMessage = "ValidationRange")]
        public int Point { get; set; }

        public bool IsDisponible { get; set; } = true;

        [DisplayName("Zombies")]
        [ValidateNever]
        public virtual List<Zombie>? Zombies { get; set; }
    }
}
