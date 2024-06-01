// Ajouter un adaptateur pour la validation de mot de passe personnalisée
$.validator.unobtrusive.adapters.add("custompassword", [], function (options) {
    options.rules['custompassword'] = true;
    options.messages['custompassword'] = options.message;
});

// Définir la méthode de validation
$.validator.addMethod("custompassword", function (value, element) {
    if (!value) {
        return false; // Ne pas valider si le champ est vide
    }

    var hasUpperCase = /[A-Z]/.test(value);
    var hasLowerCase = /[a-z]/.test(value);
    var hasDigit = /[0-9]/.test(value);

    return hasUpperCase && hasLowerCase && hasDigit;
});
