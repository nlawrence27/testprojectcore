using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCustomerDbWarehLoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "Warehouses",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "location",
                table: "Warehouses");
        }
    }
}
