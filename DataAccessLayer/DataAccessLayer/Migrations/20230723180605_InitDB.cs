using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Stocks_StockID",
                        column: x => x.StockID,
                        principalTable: "Stocks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "ID", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Vianet", 10m },
                    { 26, "MeetMe", 10m },
                    { 25, "InterNAP", 10m },
                    { 24, "Genesis", 10m },
                    { 23, "FlashZero", 10m },
                    { 22, "Epazz", 10m },
                    { 21, "Envestnet", 10m },
                    { 20, "ENDEXX", 10m },
                    { 19, "Eastern", 10m },
                    { 18, "EarthLink", 10m },
                    { 17, "CrowdGather", 10m },
                    { 16, "Crexendo", 10m },
                    { 15, "Cogent", 10m },
                    { 14, "Cnova", 10m },
                    { 13, "ChitrChatr", 10m },
                    { 12, "ADR", 10m },
                    { 11, "ChinaCache", 10m },
                    { 10, "China Finance", 10m },
                    { 9, "Carbonite", 10m },
                    { 8, "Brainybrawn", 10m },
                    { 7, "Boingo", 10m },
                    { 6, "Blucora", 10m },
                    { 5, "Blinkx", 10m },
                    { 4, "Baidu", 10m },
                    { 3, "Akamai", 10m },
                    { 2, "Agritek", 10m },
                    { 27, "Netease", 10m },
                    { 28, "Qihoo", 10m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StockID",
                table: "Orders",
                column: "StockID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
