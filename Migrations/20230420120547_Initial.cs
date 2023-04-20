using Microsoft.EntityFrameworkCore.Migrations;

namespace mission06_jrencher.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Antman and the Wasp", "Action", "Thanos", true, "N/A", "Funny", "PG-13", 2016 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Spiderman: No Way Home", "Action", "Wanda", false, "Nathan", "Best Movie Ever", "PG-13", 2022 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Endgame", "Action", "Thanos", false, "N/A", "So So Good", "PG-13", 2016 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
