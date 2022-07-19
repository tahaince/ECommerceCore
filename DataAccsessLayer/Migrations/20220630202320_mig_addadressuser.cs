using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccsessLayer.Migrations
{
    public partial class mig_addadressuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Address_AppUserId",
                table: "Address",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AspNetUsers_AppUserId",
                table: "Address",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AspNetUsers_AppUserId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_AppUserId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Address");
        }
    }
}
