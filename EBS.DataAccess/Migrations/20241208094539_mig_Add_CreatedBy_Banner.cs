using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_CreatedBy_Banner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Banners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Banners_CreatedById",
                table: "Banners",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Banners_AspNetUsers_CreatedById",
                table: "Banners",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banners_AspNetUsers_CreatedById",
                table: "Banners");

            migrationBuilder.DropIndex(
                name: "IX_Banners_CreatedById",
                table: "Banners");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Banners");
        }
    }
}
