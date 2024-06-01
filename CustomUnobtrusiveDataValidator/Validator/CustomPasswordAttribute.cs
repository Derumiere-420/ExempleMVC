using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CustomUnobtrusiveDataValidator.Validator
{
    // DataValidator pour valider un mot de passe qui doit contenir au moins
    // 1 majuscule, 1 minuscule et 1 chiffre.

    public class CustomPasswordAttribute : ValidationAttribute, IClientModelValidator
    {
        public override bool IsValid(object value)
        {
            var password = value as string;
            if (password == null) return false;

            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);

            return hasUpperCase && hasLowerCase && hasDigit;
        }

        // La méthode AddValidation est utilisée pour ajouter des attributs de validation côté client
        public void AddValidation(ClientModelValidationContext context)
        {
            // Ajout de l'attribut data-val avec la valeur true pour activer la validation côté client
            context.Attributes.Add("data-val", "true");

            // Ajout de l'attribut data-val-custompassword avec un message d'erreur personnalisé
            context.Attributes.Add("data-val-custompassword", ErrorMessage ?? "Le mot de passe doit contenir au moins une lettre majuscule, une lettre minuscule et un chiffre.");
        }
    }
}
