using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_CreatedBy_Brand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_AspNetUsers_EmployeeId",
                table: "Brands");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Brands",
                newName: "CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Brands_EmployeeId",
                table: "Brands",
                newName: "IX_Brands_CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_AspNetUsers_CreatedById",
                table: "Brands",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_AspNetUsers_CreatedById",
                table: "Brands");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Brands",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Brands_CreatedById",
                table: "Brands",
                newName: "IX_Brands_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_AspNetUsers_EmployeeId",
                table: "Brands",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
