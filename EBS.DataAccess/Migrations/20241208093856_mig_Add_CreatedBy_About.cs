using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_CreatedBy_About : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Brands",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Abouts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_EmployeeId",
                table: "Categories",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_EmployeeId",
                table: "Brands",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_CreatedById",
                table: "Abouts",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_AspNetUsers_CreatedById",
                table: "Abouts",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_AspNetUsers_EmployeeId",
                table: "Brands",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_EmployeeId",
                table: "Categories",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_AspNetUsers_CreatedById",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Brands_AspNetUsers_EmployeeId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_EmployeeId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_EmployeeId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Brands_EmployeeId",
                table: "Brands");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_CreatedById",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Abouts");
        }
    }
}
