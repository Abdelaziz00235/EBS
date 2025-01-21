using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_ValidatedBy_Order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValidatedById",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ValidatedById",
                table: "Orders",
                column: "ValidatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ValidatedById",
                table: "Orders",
                column: "ValidatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ValidatedById",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ValidatedById",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ValidatedById",
                table: "Orders");
        }
    }
}
