using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCustomerDbActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "active",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "active",
                table: "Customers");
        }
    }
}
