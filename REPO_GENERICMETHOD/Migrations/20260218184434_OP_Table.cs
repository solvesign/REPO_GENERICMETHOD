using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REPO_GENERICMETHOD.Migrations
{
    /// <inheritdoc />
    public partial class OP_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "PlayerOrder",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerOrder", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_PlayerOrder_PlayersRec_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "PlayersRec",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerOrder_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerOrder_PlayerId",
                table: "PlayerOrder",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerOrder_ProductID",
                table: "PlayerOrder",
                column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BignnersRec");

            migrationBuilder.DropTable(
                name: "PlayerOrder");

            migrationBuilder.DropTable(
                name: "PlayersRec");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
