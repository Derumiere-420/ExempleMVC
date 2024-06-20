using System;

class Boîte<T>
{
    private T contenu;

    public Boîte(T contenuInitial)
    {
        contenu = contenuInitial;
    }

    public T ObtenirContenu()
    {
        return contenu;
    }

    public void MettreContenu(T nouveauContenu)
    {
        contenu = nouveauContenu;
    }
}

class Cadeau
{
    public string Nom { get; set; }
    public double Valeur { get; set; }

    public Cadeau(string nom, double valeur)
    {
        Nom = nom;
        Valeur = valeur;
    }

    public override string ToString()
    {
        return $"Cadeau: {Nom}, Valeur: {Valeur}€";
    }
}

class Program
{
    static void Main()
    {
        // Boîte de type int
        Boîte<int> boîteInt = new Boîte<int>(123);
        Console.WriteLine("Contenu de la boîte d'entiers : " + boîteInt.ObtenirContenu()); // Sortie : 123
        boîteInt.MettreContenu(456);
        Console.WriteLine("Nouveau contenu de la boîte d'entiers : " + boîteInt.ObtenirContenu()); // Sortie : 456

        // Boîte de type string
        Boîte<string> boîteString = new Boîte<string>("Bonjour");
        Console.WriteLine("Contenu de la boîte de chaînes : " + boîteString.ObtenirContenu()); // Sortie : Bonjour
        boîteString.MettreContenu("Au revoir");
        Console.WriteLine("Nouveau contenu de la boîte de chaînes : " + boîteString.ObtenirContenu()); // Sortie : Au revoir

        // Boîte de type Cadeau
        Cadeau cadeau = new Cadeau("Montre", 199.99);
        Boîte<Cadeau> boîteCadeau = new Boîte<Cadeau>(cadeau);
        Console.WriteLine("Contenu de la boîte de cadeaux : " + boîteCadeau.ObtenirContenu()); // Sortie : Cadeau: Montre, Valeur: 199.99€
        cadeau = new Cadeau("Parfum", 79.99);
        boîteCadeau.MettreContenu(cadeau);
        Console.WriteLine("Nouveau contenu de la boîte de cadeaux : " + boîteCadeau.ObtenirContenu()); // Sortie : Cadeau: Parfum, Valeur: 79.99€
    }
}
