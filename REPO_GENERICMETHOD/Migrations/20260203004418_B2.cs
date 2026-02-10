using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REPO_GENERICMETHOD.Migrations
{
    /// <inheritdoc />
    public partial class B2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BignnersRec",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    B_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_Age = table.Column<int>(type: "int", nullable: false),
                    B_Level = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BignnersRec", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BignnersRec");
        }
    }
}
