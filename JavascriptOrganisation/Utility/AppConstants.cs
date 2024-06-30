namespace ZombieParty.Utility
{
    public static class AppConstants
    {
        // Gestion des notifications Toastr 
        public const string Success = "Success";
        public const string Error = "Error";


        // Chemins d'accès pour les fichiers/images à partir du ROOT ~
        public static string ImagePath = @"images\";
        public static string ImagePathZombies = ImagePath + @"zombies\";
        public static string ImagePathViewsZombies = @"\" + ImagePath + @"zombies\";
        public static string ImageGeneric = @"GenericZombie.png";

        // Rôles
        public const string AdminRole = "Admin";
        public const string HunterRole = "Hunter";
        public const string PlayerRole = "Player";

    }
}
