using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_CreatedBy_RequestPurchaseOrExecutionWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "RequestPurchaseOrExecutionWorks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestPurchaseOrExecutionWorks_CreatedById",
                table: "RequestPurchaseOrExecutionWorks",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestPurchaseOrExecutionWorks_AspNetUsers_CreatedById",
                table: "RequestPurchaseOrExecutionWorks",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestPurchaseOrExecutionWorks_AspNetUsers_CreatedById",
                table: "RequestPurchaseOrExecutionWorks");

            migrationBuilder.DropIndex(
                name: "IX_RequestPurchaseOrExecutionWorks_CreatedById",
                table: "RequestPurchaseOrExecutionWorks");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "RequestPurchaseOrExecutionWorks");
        }
    }
}
