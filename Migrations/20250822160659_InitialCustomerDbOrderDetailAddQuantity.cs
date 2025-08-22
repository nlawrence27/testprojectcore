using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCustomerDbOrderDetailAddQuantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "OrderDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "OrderDetails");
        }
    }
}
