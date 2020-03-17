using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroManager.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeros",
                columns: table => new
                {
                    SuperHeroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    universe = table.Column<string>(nullable: true),
                    alterEgo = table.Column<string>(nullable: true),
                    primaryAbility = table.Column<string>(nullable: true),
                    secondaryAbility = table.Column<string>(nullable: true),
                    catchPhrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeros", x => x.SuperHeroId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeros");
        }
    }
}
