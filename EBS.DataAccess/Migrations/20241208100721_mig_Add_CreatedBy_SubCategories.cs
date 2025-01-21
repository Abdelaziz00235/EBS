using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_CreatedBy_SubCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "SubCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CreatedById",
                table: "SubCategories",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_AspNetUsers_CreatedById",
                table: "SubCategories",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_AspNetUsers_CreatedById",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_CreatedById",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "SubCategories");
        }
    }
}
