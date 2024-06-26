﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pagination.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Product 1", 10.0m },
                    { 2, "Product 2", 20.0m },
                    { 3, "Product 3", 15.0m },
                    { 4, "Product 4", 20.0m },
                    { 5, "Product 5", 25.0m },
                    { 6, "Product 6", 30.0m },
                    { 7, "Product 7", 35.0m },
                    { 8, "Product 8", 40.0m },
                    { 9, "Product 9", 45.0m },
                    { 10, "Product 10", 50.0m },
                    { 11, "Product 11", 55.0m },
                    { 12, "Product 12", 60.0m },
                    { 13, "Product 13", 65.0m },
                    { 14, "Product 14", 70.0m },
                    { 15, "Product 15", 75.0m },
                    { 16, "Product 16", 80.0m },
                    { 17, "Product 17", 85.0m },
                    { 18, "Product 18", 90.0m },
                    { 19, "Product 19", 95.0m },
                    { 20, "Product 20", 100.0m },
                    { 21, "Product 21", 105.0m },
                    { 22, "Product 22", 110.0m },
                    { 23, "Product 23", 115.0m },
                    { 24, "Product 24", 120.0m },
                    { 25, "Product 25", 125.0m },
                    { 26, "Product 26", 130.0m },
                    { 27, "Product 27", 135.0m },
                    { 28, "Product 28", 140.0m },
                    { 29, "Product 29", 145.0m },
                    { 30, "Product 30", 150.0m },
                    { 31, "Product 31", 155.0m },
                    { 32, "Product 32", 160.0m },
                    { 33, "Product 33", 165.0m },
                    { 34, "Product 34", 170.0m },
                    { 35, "Product 35", 175.0m },
                    { 36, "Product 36", 180.0m },
                    { 37, "Product 37", 185.0m },
                    { 38, "Product 38", 190.0m },
                    { 39, "Product 39", 195.0m },
                    { 40, "Product 40", 200.0m },
                    { 41, "Product 41", 205.0m },
                    { 42, "Product 42", 210.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 43, "Product 43", 215.0m },
                    { 44, "Product 44", 220.0m },
                    { 45, "Product 45", 225.0m },
                    { 46, "Product 46", 230.0m },
                    { 47, "Product 47", 235.0m },
                    { 48, "Product 48", 240.0m },
                    { 49, "Product 49", 245.0m },
                    { 50, "Product 50", 250.0m },
                    { 51, "Product 51", 255.0m },
                    { 52, "Product 52", 260.0m },
                    { 53, "Product 53", 265.0m },
                    { 54, "Product 54", 270.0m },
                    { 55, "Product 55", 275.0m },
                    { 56, "Product 56", 280.0m },
                    { 57, "Product 57", 285.0m },
                    { 58, "Product 58", 290.0m },
                    { 59, "Product 59", 295.0m },
                    { 60, "Product 60", 300.0m },
                    { 61, "Product 61", 305.0m },
                    { 62, "Product 62", 310.0m },
                    { 63, "Product 63", 315.0m },
                    { 64, "Product 64", 320.0m },
                    { 65, "Product 65", 325.0m },
                    { 66, "Product 66", 330.0m },
                    { 67, "Product 67", 335.0m },
                    { 68, "Product 68", 340.0m },
                    { 69, "Product 69", 345.0m },
                    { 70, "Product 70", 350.0m },
                    { 71, "Product 71", 355.0m },
                    { 72, "Product 72", 360.0m },
                    { 73, "Product 73", 365.0m },
                    { 74, "Product 74", 370.0m },
                    { 75, "Product 75", 375.0m },
                    { 76, "Product 76", 380.0m },
                    { 77, "Product 77", 385.0m },
                    { 78, "Product 78", 390.0m },
                    { 79, "Product 79", 395.0m },
                    { 80, "Product 80", 400.0m },
                    { 81, "Product 81", 405.0m },
                    { 82, "Product 82", 410.0m },
                    { 83, "Product 83", 415.0m },
                    { 84, "Product 84", 420.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 85, "Product 85", 425.0m },
                    { 86, "Product 86", 430.0m },
                    { 87, "Product 87", 435.0m },
                    { 88, "Product 88", 440.0m },
                    { 89, "Product 89", 445.0m },
                    { 90, "Product 90", 450.0m },
                    { 91, "Product 91", 455.0m },
                    { 92, "Product 92", 460.0m },
                    { 93, "Product 93", 465.0m },
                    { 94, "Product 94", 470.0m },
                    { 95, "Product 95", 475.0m },
                    { 96, "Product 96", 480.0m },
                    { 97, "Product 97", 485.0m },
                    { 98, "Product 98", 490.0m },
                    { 99, "Product 99", 495.0m },
                    { 100, "Product 100", 500.0m },
                    { 101, "Product 101", 505.0m },
                    { 102, "Product 102", 510.0m },
                    { 103, "Product 103", 515.0m },
                    { 104, "Product 104", 520.0m },
                    { 105, "Product 105", 525.0m },
                    { 106, "Product 106", 530.0m },
                    { 107, "Product 107", 535.0m },
                    { 108, "Product 108", 540.0m },
                    { 109, "Product 109", 545.0m },
                    { 110, "Product 110", 550.0m },
                    { 111, "Product 111", 555.0m },
                    { 112, "Product 112", 560.0m },
                    { 113, "Product 113", 565.0m },
                    { 114, "Product 114", 570.0m },
                    { 115, "Product 115", 575.0m },
                    { 116, "Product 116", 580.0m },
                    { 117, "Product 117", 585.0m },
                    { 118, "Product 118", 590.0m },
                    { 119, "Product 119", 595.0m },
                    { 120, "Product 120", 600.0m },
                    { 121, "Product 121", 605.0m },
                    { 122, "Product 122", 610.0m },
                    { 123, "Product 123", 615.0m },
                    { 124, "Product 124", 620.0m },
                    { 125, "Product 125", 625.0m },
                    { 126, "Product 126", 630.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 127, "Product 127", 635.0m },
                    { 128, "Product 128", 640.0m },
                    { 129, "Product 129", 645.0m },
                    { 130, "Product 130", 650.0m },
                    { 131, "Product 131", 655.0m },
                    { 132, "Product 132", 660.0m },
                    { 133, "Product 133", 665.0m },
                    { 134, "Product 134", 670.0m },
                    { 135, "Product 135", 675.0m },
                    { 136, "Product 136", 680.0m },
                    { 137, "Product 137", 685.0m },
                    { 138, "Product 138", 690.0m },
                    { 139, "Product 139", 695.0m },
                    { 140, "Product 140", 700.0m },
                    { 141, "Product 141", 705.0m },
                    { 142, "Product 142", 710.0m },
                    { 143, "Product 143", 715.0m },
                    { 144, "Product 144", 720.0m },
                    { 145, "Product 145", 725.0m },
                    { 146, "Product 146", 730.0m },
                    { 147, "Product 147", 735.0m },
                    { 148, "Product 148", 740.0m },
                    { 149, "Product 149", 745.0m },
                    { 150, "Product 150", 750.0m },
                    { 151, "Product 151", 755.0m },
                    { 152, "Product 152", 760.0m },
                    { 153, "Product 153", 765.0m },
                    { 154, "Product 154", 770.0m },
                    { 155, "Product 155", 775.0m },
                    { 156, "Product 156", 780.0m },
                    { 157, "Product 157", 785.0m },
                    { 158, "Product 158", 790.0m },
                    { 159, "Product 159", 795.0m },
                    { 160, "Product 160", 800.0m },
                    { 161, "Product 161", 805.0m },
                    { 162, "Product 162", 810.0m },
                    { 163, "Product 163", 815.0m },
                    { 164, "Product 164", 820.0m },
                    { 165, "Product 165", 825.0m },
                    { 166, "Product 166", 830.0m },
                    { 167, "Product 167", 835.0m },
                    { 168, "Product 168", 840.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 169, "Product 169", 845.0m },
                    { 170, "Product 170", 850.0m },
                    { 171, "Product 171", 855.0m },
                    { 172, "Product 172", 860.0m },
                    { 173, "Product 173", 865.0m },
                    { 174, "Product 174", 870.0m },
                    { 175, "Product 175", 875.0m },
                    { 176, "Product 176", 880.0m },
                    { 177, "Product 177", 885.0m },
                    { 178, "Product 178", 890.0m },
                    { 179, "Product 179", 895.0m },
                    { 180, "Product 180", 900.0m },
                    { 181, "Product 181", 905.0m },
                    { 182, "Product 182", 910.0m },
                    { 183, "Product 183", 915.0m },
                    { 184, "Product 184", 920.0m },
                    { 185, "Product 185", 925.0m },
                    { 186, "Product 186", 930.0m },
                    { 187, "Product 187", 935.0m },
                    { 188, "Product 188", 940.0m },
                    { 189, "Product 189", 945.0m },
                    { 190, "Product 190", 950.0m },
                    { 191, "Product 191", 955.0m },
                    { 192, "Product 192", 960.0m },
                    { 193, "Product 193", 965.0m },
                    { 194, "Product 194", 970.0m },
                    { 195, "Product 195", 975.0m },
                    { 196, "Product 196", 980.0m },
                    { 197, "Product 197", 985.0m },
                    { 198, "Product 198", 990.0m },
                    { 199, "Product 199", 995.0m },
                    { 200, "Product 200", 1000.0m },
                    { 201, "Product 201", 1005.0m },
                    { 202, "Product 202", 1010.0m },
                    { 203, "Product 203", 1015.0m },
                    { 204, "Product 204", 1020.0m },
                    { 205, "Product 205", 1025.0m },
                    { 206, "Product 206", 1030.0m },
                    { 207, "Product 207", 1035.0m },
                    { 208, "Product 208", 1040.0m },
                    { 209, "Product 209", 1045.0m },
                    { 210, "Product 210", 1050.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 211, "Product 211", 1055.0m },
                    { 212, "Product 212", 1060.0m },
                    { 213, "Product 213", 1065.0m },
                    { 214, "Product 214", 1070.0m },
                    { 215, "Product 215", 1075.0m },
                    { 216, "Product 216", 1080.0m },
                    { 217, "Product 217", 1085.0m },
                    { 218, "Product 218", 1090.0m },
                    { 219, "Product 219", 1095.0m },
                    { 220, "Product 220", 1100.0m },
                    { 221, "Product 221", 1105.0m },
                    { 222, "Product 222", 1110.0m },
                    { 223, "Product 223", 1115.0m },
                    { 224, "Product 224", 1120.0m },
                    { 225, "Product 225", 1125.0m },
                    { 226, "Product 226", 1130.0m },
                    { 227, "Product 227", 1135.0m },
                    { 228, "Product 228", 1140.0m },
                    { 229, "Product 229", 1145.0m },
                    { 230, "Product 230", 1150.0m },
                    { 231, "Product 231", 1155.0m },
                    { 232, "Product 232", 1160.0m },
                    { 233, "Product 233", 1165.0m },
                    { 234, "Product 234", 1170.0m },
                    { 235, "Product 235", 1175.0m },
                    { 236, "Product 236", 1180.0m },
                    { 237, "Product 237", 1185.0m },
                    { 238, "Product 238", 1190.0m },
                    { 239, "Product 239", 1195.0m },
                    { 240, "Product 240", 1200.0m },
                    { 241, "Product 241", 1205.0m },
                    { 242, "Product 242", 1210.0m },
                    { 243, "Product 243", 1215.0m },
                    { 244, "Product 244", 1220.0m },
                    { 245, "Product 245", 1225.0m },
                    { 246, "Product 246", 1230.0m },
                    { 247, "Product 247", 1235.0m },
                    { 248, "Product 248", 1240.0m },
                    { 249, "Product 249", 1245.0m },
                    { 250, "Product 250", 1250.0m },
                    { 251, "Product 251", 1255.0m },
                    { 252, "Product 252", 1260.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 253, "Product 253", 1265.0m },
                    { 254, "Product 254", 1270.0m },
                    { 255, "Product 255", 1275.0m },
                    { 256, "Product 256", 1280.0m },
                    { 257, "Product 257", 1285.0m },
                    { 258, "Product 258", 1290.0m },
                    { 259, "Product 259", 1295.0m },
                    { 260, "Product 260", 1300.0m },
                    { 261, "Product 261", 1305.0m },
                    { 262, "Product 262", 1310.0m },
                    { 263, "Product 263", 1315.0m },
                    { 264, "Product 264", 1320.0m },
                    { 265, "Product 265", 1325.0m },
                    { 266, "Product 266", 1330.0m },
                    { 267, "Product 267", 1335.0m },
                    { 268, "Product 268", 1340.0m },
                    { 269, "Product 269", 1345.0m },
                    { 270, "Product 270", 1350.0m },
                    { 271, "Product 271", 1355.0m },
                    { 272, "Product 272", 1360.0m },
                    { 273, "Product 273", 1365.0m },
                    { 274, "Product 274", 1370.0m },
                    { 275, "Product 275", 1375.0m },
                    { 276, "Product 276", 1380.0m },
                    { 277, "Product 277", 1385.0m },
                    { 278, "Product 278", 1390.0m },
                    { 279, "Product 279", 1395.0m },
                    { 280, "Product 280", 1400.0m },
                    { 281, "Product 281", 1405.0m },
                    { 282, "Product 282", 1410.0m },
                    { 283, "Product 283", 1415.0m },
                    { 284, "Product 284", 1420.0m },
                    { 285, "Product 285", 1425.0m },
                    { 286, "Product 286", 1430.0m },
                    { 287, "Product 287", 1435.0m },
                    { 288, "Product 288", 1440.0m },
                    { 289, "Product 289", 1445.0m },
                    { 290, "Product 290", 1450.0m },
                    { 291, "Product 291", 1455.0m },
                    { 292, "Product 292", 1460.0m },
                    { 293, "Product 293", 1465.0m },
                    { 294, "Product 294", 1470.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 295, "Product 295", 1475.0m },
                    { 296, "Product 296", 1480.0m },
                    { 297, "Product 297", 1485.0m },
                    { 298, "Product 298", 1490.0m },
                    { 299, "Product 299", 1495.0m },
                    { 300, "Product 300", 1500.0m },
                    { 301, "Product 301", 1505.0m },
                    { 302, "Product 302", 1510.0m },
                    { 303, "Product 303", 1515.0m },
                    { 304, "Product 304", 1520.0m },
                    { 305, "Product 305", 1525.0m },
                    { 306, "Product 306", 1530.0m },
                    { 307, "Product 307", 1535.0m },
                    { 308, "Product 308", 1540.0m },
                    { 309, "Product 309", 1545.0m },
                    { 310, "Product 310", 1550.0m },
                    { 311, "Product 311", 1555.0m },
                    { 312, "Product 312", 1560.0m },
                    { 313, "Product 313", 1565.0m },
                    { 314, "Product 314", 1570.0m },
                    { 315, "Product 315", 1575.0m },
                    { 316, "Product 316", 1580.0m },
                    { 317, "Product 317", 1585.0m },
                    { 318, "Product 318", 1590.0m },
                    { 319, "Product 319", 1595.0m },
                    { 320, "Product 320", 1600.0m },
                    { 321, "Product 321", 1605.0m },
                    { 322, "Product 322", 1610.0m },
                    { 323, "Product 323", 1615.0m },
                    { 324, "Product 324", 1620.0m },
                    { 325, "Product 325", 1625.0m },
                    { 326, "Product 326", 1630.0m },
                    { 327, "Product 327", 1635.0m },
                    { 328, "Product 328", 1640.0m },
                    { 329, "Product 329", 1645.0m },
                    { 330, "Product 330", 1650.0m },
                    { 331, "Product 331", 1655.0m },
                    { 332, "Product 332", 1660.0m },
                    { 333, "Product 333", 1665.0m },
                    { 334, "Product 334", 1670.0m },
                    { 335, "Product 335", 1675.0m },
                    { 336, "Product 336", 1680.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 337, "Product 337", 1685.0m },
                    { 338, "Product 338", 1690.0m },
                    { 339, "Product 339", 1695.0m },
                    { 340, "Product 340", 1700.0m },
                    { 341, "Product 341", 1705.0m },
                    { 342, "Product 342", 1710.0m },
                    { 343, "Product 343", 1715.0m },
                    { 344, "Product 344", 1720.0m },
                    { 345, "Product 345", 1725.0m },
                    { 346, "Product 346", 1730.0m },
                    { 347, "Product 347", 1735.0m },
                    { 348, "Product 348", 1740.0m },
                    { 349, "Product 349", 1745.0m },
                    { 350, "Product 350", 1750.0m },
                    { 351, "Product 351", 1755.0m },
                    { 352, "Product 352", 1760.0m },
                    { 353, "Product 353", 1765.0m },
                    { 354, "Product 354", 1770.0m },
                    { 355, "Product 355", 1775.0m },
                    { 356, "Product 356", 1780.0m },
                    { 357, "Product 357", 1785.0m },
                    { 358, "Product 358", 1790.0m },
                    { 359, "Product 359", 1795.0m },
                    { 360, "Product 360", 1800.0m },
                    { 361, "Product 361", 1805.0m },
                    { 362, "Product 362", 1810.0m },
                    { 363, "Product 363", 1815.0m },
                    { 364, "Product 364", 1820.0m },
                    { 365, "Product 365", 1825.0m },
                    { 366, "Product 366", 1830.0m },
                    { 367, "Product 367", 1835.0m },
                    { 368, "Product 368", 1840.0m },
                    { 369, "Product 369", 1845.0m },
                    { 370, "Product 370", 1850.0m },
                    { 371, "Product 371", 1855.0m },
                    { 372, "Product 372", 1860.0m },
                    { 373, "Product 373", 1865.0m },
                    { 374, "Product 374", 1870.0m },
                    { 375, "Product 375", 1875.0m },
                    { 376, "Product 376", 1880.0m },
                    { 377, "Product 377", 1885.0m },
                    { 378, "Product 378", 1890.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 379, "Product 379", 1895.0m },
                    { 380, "Product 380", 1900.0m },
                    { 381, "Product 381", 1905.0m },
                    { 382, "Product 382", 1910.0m },
                    { 383, "Product 383", 1915.0m },
                    { 384, "Product 384", 1920.0m },
                    { 385, "Product 385", 1925.0m },
                    { 386, "Product 386", 1930.0m },
                    { 387, "Product 387", 1935.0m },
                    { 388, "Product 388", 1940.0m },
                    { 389, "Product 389", 1945.0m },
                    { 390, "Product 390", 1950.0m },
                    { 391, "Product 391", 1955.0m },
                    { 392, "Product 392", 1960.0m },
                    { 393, "Product 393", 1965.0m },
                    { 394, "Product 394", 1970.0m },
                    { 395, "Product 395", 1975.0m },
                    { 396, "Product 396", 1980.0m },
                    { 397, "Product 397", 1985.0m },
                    { 398, "Product 398", 1990.0m },
                    { 399, "Product 399", 1995.0m },
                    { 400, "Product 400", 2000.0m },
                    { 401, "Product 401", 2005.0m },
                    { 402, "Product 402", 2010.0m },
                    { 403, "Product 403", 2015.0m },
                    { 404, "Product 404", 2020.0m },
                    { 405, "Product 405", 2025.0m },
                    { 406, "Product 406", 2030.0m },
                    { 407, "Product 407", 2035.0m },
                    { 408, "Product 408", 2040.0m },
                    { 409, "Product 409", 2045.0m },
                    { 410, "Product 410", 2050.0m },
                    { 411, "Product 411", 2055.0m },
                    { 412, "Product 412", 2060.0m },
                    { 413, "Product 413", 2065.0m },
                    { 414, "Product 414", 2070.0m },
                    { 415, "Product 415", 2075.0m },
                    { 416, "Product 416", 2080.0m },
                    { 417, "Product 417", 2085.0m },
                    { 418, "Product 418", 2090.0m },
                    { 419, "Product 419", 2095.0m },
                    { 420, "Product 420", 2100.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 421, "Product 421", 2105.0m },
                    { 422, "Product 422", 2110.0m },
                    { 423, "Product 423", 2115.0m },
                    { 424, "Product 424", 2120.0m },
                    { 425, "Product 425", 2125.0m },
                    { 426, "Product 426", 2130.0m },
                    { 427, "Product 427", 2135.0m },
                    { 428, "Product 428", 2140.0m },
                    { 429, "Product 429", 2145.0m },
                    { 430, "Product 430", 2150.0m },
                    { 431, "Product 431", 2155.0m },
                    { 432, "Product 432", 2160.0m },
                    { 433, "Product 433", 2165.0m },
                    { 434, "Product 434", 2170.0m },
                    { 435, "Product 435", 2175.0m },
                    { 436, "Product 436", 2180.0m },
                    { 437, "Product 437", 2185.0m },
                    { 438, "Product 438", 2190.0m },
                    { 439, "Product 439", 2195.0m },
                    { 440, "Product 440", 2200.0m },
                    { 441, "Product 441", 2205.0m },
                    { 442, "Product 442", 2210.0m },
                    { 443, "Product 443", 2215.0m },
                    { 444, "Product 444", 2220.0m },
                    { 445, "Product 445", 2225.0m },
                    { 446, "Product 446", 2230.0m },
                    { 447, "Product 447", 2235.0m },
                    { 448, "Product 448", 2240.0m },
                    { 449, "Product 449", 2245.0m },
                    { 450, "Product 450", 2250.0m },
                    { 451, "Product 451", 2255.0m },
                    { 452, "Product 452", 2260.0m },
                    { 453, "Product 453", 2265.0m },
                    { 454, "Product 454", 2270.0m },
                    { 455, "Product 455", 2275.0m },
                    { 456, "Product 456", 2280.0m },
                    { 457, "Product 457", 2285.0m },
                    { 458, "Product 458", 2290.0m },
                    { 459, "Product 459", 2295.0m },
                    { 460, "Product 460", 2300.0m },
                    { 461, "Product 461", 2305.0m },
                    { 462, "Product 462", 2310.0m }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 463, "Product 463", 2315.0m },
                    { 464, "Product 464", 2320.0m },
                    { 465, "Product 465", 2325.0m },
                    { 466, "Product 466", 2330.0m },
                    { 467, "Product 467", 2335.0m },
                    { 468, "Product 468", 2340.0m },
                    { 469, "Product 469", 2345.0m },
                    { 470, "Product 470", 2350.0m },
                    { 471, "Product 471", 2355.0m },
                    { 472, "Product 472", 2360.0m },
                    { 473, "Product 473", 2365.0m },
                    { 474, "Product 474", 2370.0m },
                    { 475, "Product 475", 2375.0m },
                    { 476, "Product 476", 2380.0m },
                    { 477, "Product 477", 2385.0m },
                    { 478, "Product 478", 2390.0m },
                    { 479, "Product 479", 2395.0m },
                    { 480, "Product 480", 2400.0m },
                    { 481, "Product 481", 2405.0m },
                    { 482, "Product 482", 2410.0m },
                    { 483, "Product 483", 2415.0m },
                    { 484, "Product 484", 2420.0m },
                    { 485, "Product 485", 2425.0m },
                    { 486, "Product 486", 2430.0m },
                    { 487, "Product 487", 2435.0m },
                    { 488, "Product 488", 2440.0m },
                    { 489, "Product 489", 2445.0m },
                    { 490, "Product 490", 2450.0m },
                    { 491, "Product 491", 2455.0m },
                    { 492, "Product 492", 2460.0m },
                    { 493, "Product 493", 2465.0m },
                    { 494, "Product 494", 2470.0m },
                    { 495, "Product 495", 2475.0m },
                    { 496, "Product 496", 2480.0m },
                    { 497, "Product 497", 2485.0m },
                    { 498, "Product 498", 2490.0m },
                    { 499, "Product 499", 2495.0m },
                    { 500, "Product 500", 2500.0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
