using System;

interface ILouable
{
    void Louer();
    void Retourner();
}

class Vehicule
{
    public string PlaqueImmatriculation { get; set; }
    public string Marque { get; set; }

    public void Demarrer()
    {
        Console.WriteLine("Démarrage du véhicule..."); // Sortie à l'écran : "Démarrage du véhicule..."
    }

    public void Arreter()
    {
        Console.WriteLine("Arrêt du véhicule..."); // Sortie à l'écran : "Arrêt du véhicule..."
    }
}

class Voiture : Vehicule, ILouable
{
    public int NombreDePortes { get; set; }

    public void Louer()
    {
        Console.WriteLine($"Location de la voiture avec la plaque d'immatriculation {PlaqueImmatriculation}"); // Sortie à l'écran : "Location de la voiture avec la plaque d'immatriculation {PlaqueImmatriculation}"
    }

    public void Retourner()
    {
        Console.WriteLine($"Retour de la voiture avec la plaque d'immatriculation {PlaqueImmatriculation}"); // Sortie à l'écran : "Retour de la voiture avec la plaque d'immatriculation {PlaqueImmatriculation}"
    }
}

class Velo : Vehicule, ILouable
{
    public bool AUnPanier { get; set; }

    public void Louer()
    {
        Console.WriteLine($"Location du vélo avec la plaque d'immatriculation {PlaqueImmatriculation}"); // Sortie à l'écran : "Location du vélo avec la plaque d'immatriculation {PlaqueImmatriculation}"
    }

    public void Retourner()
    {
        Console.WriteLine($"Retour du vélo avec la plaque d'immatriculation {PlaqueImmatriculation}"); // Sortie à l'écran : "Retour du vélo avec la plaque d'immatriculation {PlaqueImmatriculation}"
    }
}

class Program
{
    static void Main()
    {
        Voiture maVoiture = new Voiture
        {
            PlaqueImmatriculation = "ABC123",
            Marque = "Toyota",
            NombreDePortes = 4
        };

        Velo monVelo = new Velo
        {
            PlaqueImmatriculation = "XYZ789",
            Marque = "Giant",
            AUnPanier = true
        };

        maVoiture.Demarrer(); // Sortie à l'écran : "Démarrage du véhicule..."
        maVoiture.Louer(); // Sortie à l'écran : "Location de la voiture avec la plaque d'immatriculation ABC123"
        maVoiture.Arreter(); // Sortie à l'écran : "Arrêt du véhicule..."
        maVoiture.Retourner(); // Sortie à l'écran : "Retour de la voiture avec la plaque d'immatriculation ABC123"

        Console.WriteLine();

        monVelo.Demarrer(); // Sortie à l'écran : "Démarrage du véhicule..."
        monVelo.Louer(); // Sortie à l'écran : "Location du vélo avec la plaque d'immatriculation XYZ789"
        monVelo.Arreter(); // Sortie à l'écran : "Arrêt du véhicule..."
        monVelo.Retourner(); // Sortie à l'écran : "Retour du vélo avec la plaque d'immatriculation XYZ789"
    }
}
