using CustomUnobtrusiveDataValidator.Validator;
using System.ComponentModel.DataAnnotations;

namespace CustomUnobtrusiveDataValidator.Models
{
    public class Utilisateur
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Name { get; set; }

        [Required(ErrorMessage = "L'adresse e-mail est obligatoire")]
        [EmailAddress(ErrorMessage = "Format de l'adresse e-mail invalide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
        //DataValidator personnalisé
        [CustomPassword(ErrorMessage = "Le mot de passe doit contenir au moins une lettre majuscule, une lettre minuscule et un chiffre")]
        public string Password { get; set; }
    }

}
