using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Filtre.Models;

public class MyDbContext : DbContext
{

    public DbSet<Filtre.Models.Produit> Produit { get; set; } = default!;
    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Produit>().HasData(SeedProduits());
    }

    private Produit[] SeedProduits()
    {
        var rnd = new Random();
        var categories = new[] { "Outils de Jardin", "Outils de Cuisine", "Outils de Bureau", "Outils de Construction", "Outils Électroniques" };
        var produits = new List<Produit>();

        for (int i = 1; i <= 100; i++)
        {
            produits.Add(new Produit
            {
                Id = i,
                Nom = $"Produit{i}",
                Cout = (decimal)(rnd.Next(1, 1000) + rnd.NextDouble()),
                Categorie = categories[rnd.Next(categories.Length)]
            });
        }

        return produits.ToArray();
    }

    
}
