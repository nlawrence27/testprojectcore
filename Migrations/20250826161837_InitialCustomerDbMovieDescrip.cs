using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCustomerDbMovieDescrip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Movies",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Movies");
        }
    }
}
