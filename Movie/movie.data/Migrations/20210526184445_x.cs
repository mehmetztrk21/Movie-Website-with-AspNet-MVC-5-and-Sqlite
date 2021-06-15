using Microsoft.EntityFrameworkCore.Migrations;

namespace movie.data.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "director_name",
                table: "Movies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "süre",
                table: "Movies",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "director_name",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "süre",
                table: "Movies");
        }
    }
}
