using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    public partial class AjoutZombieImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Zombies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "Lenore.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "Baron Samedi.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "Draugr.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Image", "Name" },
                values: new object[] { "", "Ragamuffin.png" });

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "Mr Gosh.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Image", "Name" },
                values: new object[] { "Taxidermy.png", "Taxidermy" });

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "Kitty.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "Singe zombie.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "Avogadro.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "Lady Rose");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "Matbeth.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "The Clown.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "Clicker.png");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Image", "Name" },
                values: new object[] { "TeamsZombie", "TeamsZombie.png" });

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "Mathilde.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Zombies");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Ragamuffin ");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Taxidermy ");

            migrationBuilder.UpdateData(
                table: "Zombies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "TeamsZombie");
        }
    }
}
