using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_CreatedBy_Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_EmployeeId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Categories",
                newName: "CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_EmployeeId",
                table: "Categories",
                newName: "IX_Categories_CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedById",
                table: "Categories",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_CreatedById",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "Categories",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_CreatedById",
                table: "Categories",
                newName: "IX_Categories_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_EmployeeId",
                table: "Categories",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
