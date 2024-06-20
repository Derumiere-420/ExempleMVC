using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OverPosting.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "Id", "Email", "EstAdmin", "Nom" },
                values: new object[,]
                {
                    { 1, "alice.dupont@example.com", false, "Alice Dupont" },
                    { 2, "bob.martin@example.com", false, "Bob Martin" },
                    { 3, "charlie.durand@example.com", false, "Charlie Durand" },
                    { 4, "david.leroy@example.com", false, "David Leroy" },
                    { 5, "eva.bernard@example.com", false, "Eva Bernard" },
                    { 6, "franck.dubois@example.com", false, "Franck Dubois" },
                    { 7, "gina.moreau@example.com", false, "Gina Moreau" },
                    { 8, "hugo.petit@example.com", false, "Hugo Petit" },
                    { 9, "isabelle.thomas@example.com", false, "Isabelle Thomas" },
                    { 10, "julien.fontaine@example.com", false, "Julien Fontaine" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
