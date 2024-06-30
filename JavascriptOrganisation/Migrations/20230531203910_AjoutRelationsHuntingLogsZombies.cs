using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    public partial class AjoutRelationsHuntingLogsZombies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HuntingLogZombie",
                columns: table => new
                {
                    HuntingLogsId = table.Column<int>(type: "int", nullable: false),
                    ZombiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntingLogZombie", x => new { x.HuntingLogsId, x.ZombiesId });
                    table.ForeignKey(
                        name: "FK_HuntingLogZombie_HuntingLogs_HuntingLogsId",
                        column: x => x.HuntingLogsId,
                        principalTable: "HuntingLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HuntingLogZombie_Zombies_ZombiesId",
                        column: x => x.ZombiesId,
                        principalTable: "Zombies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuntingLogZombie_ZombiesId",
                table: "HuntingLogZombie",
                column: "ZombiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HuntingLogZombie");
        }
    }
}
