using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCustomerDbAddMovieTittle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "movie_od",
                table: "Movies",
                newName: "movie_id");

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Movies",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "title",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "movie_id",
                table: "Movies",
                newName: "movie_od");
        }
    }
}
