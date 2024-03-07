using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeApplication.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddImageSource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    IdDBMeal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StrImageSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMeal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrInstructions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.IdDBMeal);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");
        }
    }
}
