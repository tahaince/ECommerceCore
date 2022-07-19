using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccsessLayer.Migrations
{
    public partial class mig_add_add_procutcart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Orders_AspNetUsers_AppUserId",
            //    table: "Orders");

            //migrationBuilder.DropIndex(
            //    name: "IX_Orders_AppUserId",
            //    table: "Orders");

            //migrationBuilder.DropColumn(
            //    name: "AppUserId",
            //    table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderSepets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderSepets_ProductId",
                table: "OrderSepets",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderSepets_Products_ProductId",
                table: "OrderSepets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderSepets_Products_ProductId",
                table: "OrderSepets");

            migrationBuilder.DropIndex(
                name: "IX_OrderSepets_ProductId",
                table: "OrderSepets");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderSepets");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
