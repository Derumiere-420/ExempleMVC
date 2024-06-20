using System;
using System.Collections.Generic;

class Personne
{
    public string Nom { get; set; }
}

class Entreprise
{
    private List<Personne> employés = new List<Personne>();

    public Entreprise()
    {
        employés.Add(new Personne { Nom = "Alice" });
        employés.Add(new Personne { Nom = "Bob" });
    }

    // Expose la liste des employés comme un IReadOnlyList<Personne>
    public IReadOnlyList<Personne> Employés => employés.AsReadOnly();
}

class Program
{
    static void Main()
    {
        Entreprise entreprise = new Entreprise();
        IReadOnlyList<Personne> employés = entreprise.Employés;

        // Affiche le nom de chaque employé
        foreach (var employé in employés)
        {
            Console.WriteLine(employé.Nom);
        }

        // La ligne suivante provoquerait une erreur de compilation
        // employés.Add(new Personne { Nom = "Charlie" });
    }
}
