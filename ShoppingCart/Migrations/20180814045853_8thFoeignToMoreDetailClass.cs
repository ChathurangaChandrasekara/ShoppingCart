using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCart.Migrations
{
    public partial class _8thFoeignToMoreDetailClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SignUpId",
                table: "MoreDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MoreDetails_SignUpId",
                table: "MoreDetails",
                column: "SignUpId");

            migrationBuilder.AddForeignKey(
                name: "FK_MoreDetails_SignUps_SignUpId",
                table: "MoreDetails",
                column: "SignUpId",
                principalTable: "SignUps",
                principalColumn: "SignUpId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoreDetails_SignUps_SignUpId",
                table: "MoreDetails");

            migrationBuilder.DropIndex(
                name: "IX_MoreDetails_SignUpId",
                table: "MoreDetails");

            migrationBuilder.DropColumn(
                name: "SignUpId",
                table: "MoreDetails");
        }
    }
}
