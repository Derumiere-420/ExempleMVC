using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;

namespace ZombieParty.Models
{
    public class Zombie
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [DisplayName("ShortDesc")]
        [StringLength(255)]
        public string ShortDesc { get; set; }

        [DisplayName("Point")]
        [Range(1, 20, ErrorMessage = "ValidationRange")]
        public int Point { get; set; }

        [DisplayName("ForceLevel")]
        public int Force { get; set; }

        public bool IsFavorite { get; set; }

        [Display(Name = "Image")]
        [ValidateNever]
        public string Image{ get; set; } = "";

        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [Display(Name = "ZombieType")]
        [ForeignKey("ZombieType")]
        public int ZombieTypeId { get; set; }
        [ValidateNever] 
        public virtual ZombieType? ZombieType { get; set; }

        [Display(Name = "HuntingLogs")]
        [ValidateNever] 
        public virtual List<HuntingLog> HuntingLogs { get; set; }
    }
}
