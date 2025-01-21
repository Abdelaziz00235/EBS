using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_CreatedBy_Suppliers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CreatedById",
                table: "Suppliers",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_AspNetUsers_CreatedById",
                table: "Suppliers",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_AspNetUsers_CreatedById",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_CreatedById",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Suppliers");
        }
    }
}
