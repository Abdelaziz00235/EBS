using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EBS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_Add_ValidatedBy_RequestPurchaseOrExecutionWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValidatedById",
                table: "RequestPurchaseOrExecutionWorks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestPurchaseOrExecutionWorks_ValidatedById",
                table: "RequestPurchaseOrExecutionWorks",
                column: "ValidatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestPurchaseOrExecutionWorks_AspNetUsers_ValidatedById",
                table: "RequestPurchaseOrExecutionWorks",
                column: "ValidatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestPurchaseOrExecutionWorks_AspNetUsers_ValidatedById",
                table: "RequestPurchaseOrExecutionWorks");

            migrationBuilder.DropIndex(
                name: "IX_RequestPurchaseOrExecutionWorks_ValidatedById",
                table: "RequestPurchaseOrExecutionWorks");

            migrationBuilder.DropColumn(
                name: "ValidatedById",
                table: "RequestPurchaseOrExecutionWorks");
        }
    }
}
