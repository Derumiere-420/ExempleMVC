using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    public partial class SeedZombieZombieTypeWeapon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "WeaponId", "CreatedDate", "Description", "Force", "Image", "Name", "Price", "Qty", "QtyBought" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is to cut your friendly zombies", 200m, "https://i.ibb.co/y5nCnXT/dagger-gfce31e967-1920.png", "Leopold", 421m, 21, 3 },
                    { 2, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An awesome Stainless Steel Shield", 10m, "https://publicdomainvectors.org/photos/Shield-ClassicMedieval1.png", "Master Shield", 500m, 30, 1 }
                });

            migrationBuilder.InsertData(
                table: "ZombieTypes",
                columns: new[] { "Id", "Point", "TypeName" },
                values: new object[,]
                {
                    { 1, 0, "Contact" },
                    { 2, 0, "Virus" },
                    { 3, 0, "Chimique" },
                    { 4, 0, "Morsure" },
                    { 5, 0, "vampzombie" }
                });

            migrationBuilder.InsertData(
                table: "Zombies",
                columns: new[] { "Id", "Name", "Point", "ShortDesc", "ZombieTypeId" },
                values: new object[,]
                {
                    { 1, "LeChuck", 5, "Pirate des Caraibes", 1 },
                    { 2, "Lenore", 4, "Cute Little Dead Girl", 2 },
                    { 3, "Baron Samedi", 8, "En costume de soirée, avec un chapeau haut de forme blanc et des lunettes soleil", 2 },
                    { 4, "Draugr", 2, "Vivant dans sa tombe grandant son trésor", 3 },
                    { 5, "Ragamuffin ", 5, "Ancien vampire transformé en poupée de chiffon, ami de Lenore", 2 },
                    { 6, "Mr Gosh", 6, "Tête de sac avec yeux en boutons, amoureux de Lenore", 1 },
                    { 7, "Taxidermy ", 1, "Tête de cerf empaillé, voisin de Lenore", 3 },
                    { 8, "Kitty", 3, "Chat mort de Lenore", 1 },
                    { 9, "Singe zombie", 2, "Voleur très rapide", 3 },
                    { 10, "chien de l'enfer", 7, "chien très rapide, pouvant être enflammé", 3 },
                    { 11, "Avogadro", 9, "Attaque avec des éclairs suite à un orage", 3 },
                    { 12, "Lady Rose", 6, "", 3 },
                    { 13, "Matbeth", 2, "Jeune étudiante qui cherche son professeur pour se venger", 2 },
                    { 14, "The Clown", 5, "Le clown malheureux qui court après les enfants", 3 },
                    { 15, "Clicker", 4, "Le comptable mécontent qui cherche les failles", 2 },
                    { 16, "TeamsZombie", 10, "L'étudiant happé par Teams. Trop d'heures de vidéos ont transformé cet étudiant en zombie", 3 },
                    { 17, "Mathilde", 4, "La fêtarde du samedi soir qui cherche les fêtes et les bars en vogue", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
