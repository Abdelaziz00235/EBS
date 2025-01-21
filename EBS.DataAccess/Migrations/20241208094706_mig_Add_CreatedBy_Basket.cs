using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_CreatedBy_Basket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Baskets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_CreatedById",
                table: "Baskets",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_AspNetUsers_CreatedById",
                table: "Baskets",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_AspNetUsers_CreatedById",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_CreatedById",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Baskets");
        }
    }
}
