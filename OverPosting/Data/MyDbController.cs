using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OverPosting.Models;

public class MyDbController : DbContext
{
    public MyDbController(DbContextOptions<MyDbController> options)
        : base(options)
    {
    }

    public DbSet<OverPosting.Models.Utilisateur> Utilisateur { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Utilisateur>().HasData(
            new Utilisateur { Id = 1, Nom = "Alice Dupont", Email = "alice.dupont@example.com", EstAdmin = false },
            new Utilisateur { Id = 2, Nom = "Bob Martin", Email = "bob.martin@example.com", EstAdmin = false },
            new Utilisateur { Id = 3, Nom = "Charlie Durand", Email = "charlie.durand@example.com", EstAdmin = false },
            new Utilisateur { Id = 4, Nom = "David Leroy", Email = "david.leroy@example.com",  EstAdmin = false },
            new Utilisateur { Id = 5, Nom = "Eva Bernard", Email = "eva.bernard@example.com", EstAdmin = false },
            new Utilisateur { Id = 6, Nom = "Franck Dubois", Email = "franck.dubois@example.com", EstAdmin = false },
            new Utilisateur { Id = 7, Nom = "Gina Moreau", Email = "gina.moreau@example.com", EstAdmin = false },
            new Utilisateur { Id = 8, Nom = "Hugo Petit", Email = "hugo.petit@example.com",  EstAdmin = false },
            new Utilisateur { Id = 9, Nom = "Isabelle Thomas", Email = "isabelle.thomas@example.com", EstAdmin = false },
            new Utilisateur { Id = 10, Nom = "Julien Fontaine", Email = "julien.fontaine@example.com", EstAdmin = false }
        );
    }
}
