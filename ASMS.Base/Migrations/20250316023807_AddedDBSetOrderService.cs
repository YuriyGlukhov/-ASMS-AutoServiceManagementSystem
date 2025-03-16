using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASMS.Base.Migrations
{
    /// <inheritdoc />
    public partial class AddedDBSetOrderService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderService_Orders_OrderId",
                table: "OrderService");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderService_Services_ServiceId",
                table: "OrderService");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderService",
                table: "OrderService");

            migrationBuilder.RenameTable(
                name: "OrderService",
                newName: "OrderServices");

            migrationBuilder.RenameIndex(
                name: "IX_OrderService_ServiceId",
                table: "OrderServices",
                newName: "IX_OrderServices_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderServices",
                table: "OrderServices",
                columns: new[] { "OrderId", "ServiceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderServices_Orders_OrderId",
                table: "OrderServices",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderServices_Services_ServiceId",
                table: "OrderServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderServices_Orders_OrderId",
                table: "OrderServices");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderServices_Services_ServiceId",
                table: "OrderServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderServices",
                table: "OrderServices");

            migrationBuilder.RenameTable(
                name: "OrderServices",
                newName: "OrderService");

            migrationBuilder.RenameIndex(
                name: "IX_OrderServices_ServiceId",
                table: "OrderService",
                newName: "IX_OrderService_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderService",
                table: "OrderService",
                columns: new[] { "OrderId", "ServiceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderService_Orders_OrderId",
                table: "OrderService",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderService_Services_ServiceId",
                table: "OrderService",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
