using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Filtre.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cout = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produit",
                columns: new[] { "Id", "Categorie", "Cout", "Nom" },
                values: new object[,]
                {
                    { 1, "Outils de Bureau", 705.56699541469m, "Produit1" },
                    { 2, "Outils de Jardin", 205.100952164347m, "Produit2" },
                    { 3, "Outils de Bureau", 206.520016288287m, "Produit3" },
                    { 4, "Outils de Cuisine", 588.071161974821m, "Produit4" },
                    { 5, "Outils de Cuisine", 280.450317584915m, "Produit5" },
                    { 6, "Outils de Construction", 15.9243383287001m, "Produit6" },
                    { 7, "Outils Électroniques", 392.906242148192m, "Produit7" },
                    { 8, "Outils de Bureau", 687.429973987551m, "Produit8" },
                    { 9, "Outils de Bureau", 255.779996475871m, "Produit9" },
                    { 10, "Outils de Cuisine", 527.727348369815m, "Produit10" },
                    { 11, "Outils Électroniques", 740.028947672801m, "Produit11" },
                    { 12, "Outils de Bureau", 577.045086090831m, "Produit12" },
                    { 13, "Outils de Bureau", 575.514482892407m, "Produit13" },
                    { 14, "Outils de Bureau", 591.31666940571m, "Produit14" },
                    { 15, "Outils de Cuisine", 454.380084315283m, "Produit15" },
                    { 16, "Outils Électroniques", 500.678584022162m, "Produit16" },
                    { 17, "Outils Électroniques", 250.8492565562m, "Produit17" },
                    { 18, "Outils de Jardin", 285.845113980063m, "Produit18" },
                    { 19, "Outils Électroniques", 765.707879989936m, "Produit19" },
                    { 20, "Outils de Bureau", 613.996225096506m, "Produit20" },
                    { 21, "Outils de Bureau", 913.708009184157m, "Produit21" },
                    { 22, "Outils Électroniques", 994.575586954089m, "Produit22" },
                    { 23, "Outils de Construction", 623.835665524928m, "Produit23" },
                    { 24, "Outils de Construction", 724.81820721172m, "Produit24" },
                    { 25, "Outils de Construction", 14.4342123921906m, "Produit25" },
                    { 26, "Outils de Bureau", 709.566820810732m, "Produit26" },
                    { 27, "Outils de Construction", 87.2406831277236m, "Produit27" },
                    { 28, "Outils Électroniques", 578.034678789432m, "Produit28" },
                    { 29, "Outils de Bureau", 416.327541467702m, "Produit29" },
                    { 30, "Outils de Construction", 727.735815188154m, "Produit30" },
                    { 31, "Outils Électroniques", 30.8173510185216m, "Produit31" },
                    { 32, "Outils Électroniques", 649.672729859451m, "Produit32" },
                    { 33, "Outils de Bureau", 61.4927058273642m, "Produit33" },
                    { 34, "Outils de Construction", 961.990867710898m, "Produit34" },
                    { 35, "Outils Électroniques", 12.5256704614207m, "Produit35" },
                    { 36, "Outils de Bureau", 800.40531426256m, "Produit36" },
                    { 37, "Outils de Construction", 813.212996925921m, "Produit37" },
                    { 38, "Outils de Bureau", 749.359517368722m, "Produit38" },
                    { 39, "Outils de Bureau", 607.810458938784m, "Produit39" },
                    { 40, "Outils de Cuisine", 792.524020508284m, "Produit40" },
                    { 41, "Outils de Bureau", 290.90193809216m, "Produit41" },
                    { 42, "Outils Électroniques", 841.97791475142m, "Produit42" }
                });

            migrationBuilder.InsertData(
                table: "Produit",
                columns: new[] { "Id", "Categorie", "Cout", "Nom" },
                values: new object[,]
                {
                    { 43, "Outils Électroniques", 613.877867317218m, "Produit43" },
                    { 44, "Outils Électroniques", 641.277676328149m, "Produit44" },
                    { 45, "Outils de Bureau", 271.675399489621m, "Produit45" },
                    { 46, "Outils de Cuisine", 461.279509603834m, "Produit46" },
                    { 47, "Outils de Jardin", 445.947469937594m, "Produit47" },
                    { 48, "Outils de Cuisine", 512.972882156412m, "Produit48" },
                    { 49, "Outils Électroniques", 65.1867425422865m, "Produit49" },
                    { 50, "Outils Électroniques", 460.29262242973m, "Produit50" },
                    { 51, "Outils de Jardin", 363.675986057048m, "Produit51" },
                    { 52, "Outils de Jardin", 23.4858382992387m, "Produit52" },
                    { 53, "Outils Électroniques", 928.498345811805m, "Produit53" },
                    { 54, "Outils de Cuisine", 43.7762721932401m, "Produit54" },
                    { 55, "Outils Électroniques", 924.19060990014m, "Produit55" },
                    { 56, "Outils de Cuisine", 536.89064373376m, "Produit56" },
                    { 57, "Outils de Cuisine", 725.497648325722m, "Produit57" },
                    { 58, "Outils de Cuisine", 743.618909674994m, "Produit58" },
                    { 59, "Outils de Jardin", 392.254958749378m, "Produit59" },
                    { 60, "Outils de Construction", 516.168568816513m, "Produit60" },
                    { 61, "Outils Électroniques", 327.318159684681m, "Produit61" },
                    { 62, "Outils de Cuisine", 403.740355932213m, "Produit62" },
                    { 63, "Outils de Construction", 913.389838494063m, "Produit63" },
                    { 64, "Outils Électroniques", 882.226561482223m, "Produit64" },
                    { 65, "Outils Électroniques", 974.695765296579m, "Produit65" },
                    { 66, "Outils de Bureau", 848.938516810375m, "Produit66" },
                    { 67, "Outils de Bureau", 85.3691200686986m, "Produit67" },
                    { 68, "Outils de Jardin", 316.149773708641m, "Produit68" },
                    { 69, "Outils Électroniques", 586.365199944543m, "Produit69" },
                    { 70, "Outils de Cuisine", 283.798142264672m, "Produit70" },
                    { 71, "Outils de Jardin", 654.156118295999m, "Produit71" },
                    { 72, "Outils de Bureau", 312.773502524768m, "Produit72" },
                    { 73, "Outils de Cuisine", 269.706004026048m, "Produit73" },
                    { 74, "Outils de Cuisine", 763.54156867921m, "Produit74" },
                    { 75, "Outils de Bureau", 328.366043835136m, "Produit75" },
                    { 76, "Outils de Bureau", 686.50366557886m, "Produit76" },
                    { 77, "Outils de Bureau", 298.615715395412m, "Produit77" },
                    { 78, "Outils de Construction", 282.216137894946m, "Produit78" },
                    { 79, "Outils de Jardin", 145.99891194452m, "Produit79" },
                    { 80, "Outils de Bureau", 602.83638558436m, "Produit80" },
                    { 81, "Outils de Bureau", 811.480433094934m, "Produit81" },
                    { 82, "Outils Électroniques", 950.565313729813m, "Produit82" },
                    { 83, "Outils de Bureau", 794.63873019848m, "Produit83" },
                    { 84, "Outils de Bureau", 129.914363484727m, "Produit84" }
                });

            migrationBuilder.InsertData(
                table: "Produit",
                columns: new[] { "Id", "Categorie", "Cout", "Nom" },
                values: new object[,]
                {
                    { 85, "Outils Électroniques", 55.1769831079741m, "Produit85" },
                    { 86, "Outils de Construction", 475.41834151161m, "Produit86" },
                    { 87, "Outils de Jardin", 613.211863272184m, "Produit87" },
                    { 88, "Outils de Construction", 701.592612715425m, "Produit88" },
                    { 89, "Outils de Construction", 535.010671993226m, "Produit89" },
                    { 90, "Outils Électroniques", 796.605680708892m, "Produit90" },
                    { 91, "Outils de Bureau", 758.102002920099m, "Produit91" },
                    { 92, "Outils Électroniques", 56.9281756123298m, "Produit92" },
                    { 93, "Outils de Cuisine", 992.327517579421m, "Produit93" },
                    { 94, "Outils de Cuisine", 715.63885409924m, "Produit94" },
                    { 95, "Outils de Construction", 401.758375935812m, "Produit95" },
                    { 96, "Outils de Bureau", 89.7491597003674m, "Produit96" },
                    { 97, "Outils de Cuisine", 214.620418708293m, "Produit97" },
                    { 98, "Outils de Construction", 854.717016320794m, "Produit98" },
                    { 99, "Outils Électroniques", 585.725173308487m, "Produit99" },
                    { 100, "Outils de Construction", 140.432921751813m, "Produit100" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produit");
        }
    }
}
