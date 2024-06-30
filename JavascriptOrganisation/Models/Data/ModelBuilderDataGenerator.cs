using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty.Models;

namespace ZombieParty.Data
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {

            #region Zombie
            builder.Entity<Zombie>().HasData(
                new Zombie { Id = 1, Point = 5, Force = 20, ShortDesc = "Pirate des Caraibes", Name = "LeChuck", Image = "", ZombieTypeId = 1 },
                new Zombie { Id = 2, Point = 4, Force = 10, ShortDesc = "Cute Little Dead Girl", Name = "Lenore", Image = "Lenore.png", ZombieTypeId = 2 },
                new Zombie { Id = 3, Point = 8, Force = 12, ShortDesc = "En costume de soirée, avec un chapeau haut de forme blanc et des lunettes soleil", Name = "Baron Samedi", Image = "Baron Samedi.png", ZombieTypeId = 2 },
                new Zombie { Id = 4, Point = 2, Force = 5, ShortDesc = "Vivant dans sa tombe grandant son trésor", Name = "Draugr", Image = "Draugr.png", ZombieTypeId = 3 },
                new Zombie { Id = 5, Point = 5, Force = 20, ShortDesc = "Ancien vampire transformé en poupée de chiffon, ami de Lenore", Name = "Ragamuffin.png", Image = "", ZombieTypeId = 2 },
                new Zombie { Id = 6, Point = 6, Force = 5, ShortDesc = "Tête de sac avec yeux en boutons, amoureux de Lenore", Name = "Mr Gosh", Image = "Mr Gosh.png", ZombieTypeId = 1 },
                new Zombie { Id = 7, Point = 1, Force = 12, ShortDesc = "Tête de cerf empaillé, voisin de Lenore", Name = "Taxidermy", Image = "Taxidermy.png", ZombieTypeId = 3 },
                new Zombie { Id = 8, Point = 3, Force = 10, ShortDesc = "Chat mort de Lenore", Name = "Kitty", Image = "Kitty.png", ZombieTypeId = 1 },
                new Zombie { Id = 9, Point = 2, Force = 20, ShortDesc = "Voleur très rapide", Name = "Singe zombie", Image = "Singe zombie.png", ZombieTypeId = 3 },
                new Zombie { Id = 10, Point = 7, Force = 23, ShortDesc = "chien très rapide, pouvant être enflammé", Name = "chien de l'enfer", Image = "", ZombieTypeId = 3 },
                new Zombie { Id = 11, Point = 9, Force = 15, ShortDesc = "Attaque avec des éclairs suite à un orage", Name = "Avogadro", Image = "Avogadro.png", ZombieTypeId = 3 },
                new Zombie { Id = 12, Point = 6, Force = 10, ShortDesc = "", Name = "Lady Rose", Image = "Lady Rose.png", ZombieTypeId = 3 },
                new Zombie { Id = 13, Point = 2, Force = 4, ShortDesc = "Jeune étudiante qui cherche son professeur pour se venger", Name = "Matbeth", Image = "Matbeth.png", ZombieTypeId = 2 },
                new Zombie { Id = 14, Point = 5, Force = 5, ShortDesc = "Le clown malheureux qui court après les enfants", Name = "The Clown", Image = "The Clown.png", ZombieTypeId = 3 },
                new Zombie { Id = 15, Point = 4, Force = 10, ShortDesc = "Le comptable mécontent qui cherche les failles", Name = "Clicker", Image = "Clicker.png", ZombieTypeId = 2 },
                new Zombie { Id = 16, Point = 10, Force = 12, ShortDesc = "L'étudiant happé par Teams. Trop d'heures de vidéos ont transformé cet étudiant en zombie", Name = "TeamsZombie ", Image = "TeamsZombie.png", ZombieTypeId = 3 },
                new Zombie { Id = 17, Point = 4, Force = 20, ShortDesc = "La fêtarde du samedi soir qui cherche les fêtes et les bars en vogue", Name = "Mathilde", Image = "Mathilde.png", ZombieTypeId = 3 }
            );
            #endregion

            #region ZombieType
            builder.Entity<ZombieType>().HasData(
                new ZombieType { Id = 1, Point= 3, TypeName = "Contact" },
                new ZombieType { Id = 2, Point = 2, TypeName = "Virus" },
                new ZombieType { Id = 3, Point = 3, TypeName = "Chimique" },
                new ZombieType { Id = 4, Point = 4, TypeName = "Morsure" },
                new ZombieType { Id = 5, Point = 5, TypeName = "vampzombie" }
            );
            #endregion

            #region Weapon
            builder.Entity<Weapon>().HasData(
                new Weapon() { WeaponId = 1, Name = "Leopold", Description = "This is to cut your friendly zombies", Force = 200, Image = "https://i.ibb.co/y5nCnXT/dagger-gfce31e967-1920.png", Price = 421, Qty = 21, QtyBought = 3, CreatedDate = new DateTime(1999, 01, 1) },
                new Weapon() { WeaponId = 2, Name = "Master Shield", Description = "An awesome Stainless Steel Shield", Force = 10, Image = "https://publicdomainvectors.org/photos/Shield-ClassicMedieval1.png", Price = 500, Qty = 30, QtyBought = 1, CreatedDate = new DateTime(1999, 01, 1) },
                new Weapon() { WeaponId = 3, Name = "Dwarven Mace", Description = "A Dwarven Mace! Same size as a normal mace...", Force = 48, Image = "https://publicdomainvectors.org/photos/Dwarven-Mace.png", Price = 600, Qty = 42, QtyBought = 18, CreatedDate = new DateTime(1990, 10, 31) }
            );
            #endregion
        }
    }
}
