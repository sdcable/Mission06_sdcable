using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_sdcable.Migrations
{
    public partial class newDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Fantasy", "Chris Columbus", false, "", "", "PG", "Harry Potter and the Sorcerer's Stone", 2001 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Sci-Fi", "George Lucas", false, "", "", "PG", "Star Wars: Episode IV -- A New Hope", 1977 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action", "Chris McKay", false, "", "", "PG", "The Lego Batman Movie", 2017 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "responses",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "responses",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "responses",
                keyColumn: "MovieId",
                keyValue: 3);
        }
    }
}
