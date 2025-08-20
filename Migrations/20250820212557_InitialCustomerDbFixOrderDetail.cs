using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCustomerDbFixOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ordeDetail_id",
                table: "OrderDetails",
                newName: "orderDetail_id");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "OrderDetails",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "orderDetail_id",
                table: "OrderDetails",
                newName: "ordeDetail_id");
        }
    }
}
