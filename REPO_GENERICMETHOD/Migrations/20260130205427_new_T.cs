using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REPO_GENERICMETHOD.Migrations
{
    /// <inheritdoc />
    public partial class new_T : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayersRec",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Player_Age = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Player_Lavel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersRec", x => x.PlayerID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayersRec");
        }
    }
}
