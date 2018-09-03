using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCart.Migrations
{
    public partial class clearForeignKeyDependies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategories_ItemCategoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_SignUps_SignUpId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_MoreDetails_SignUps_SignUpId",
                table: "MoreDetails");

            migrationBuilder.DropIndex(
                name: "IX_MoreDetails_SignUpId",
                table: "MoreDetails");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemCategoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_SignUpId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "SignUpId",
                table: "MoreDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SignUpId",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemCategoryId",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SignUpId",
                table: "ItemCategories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SignUpId",
                table: "ItemCategories");

            migrationBuilder.AlterColumn<int>(
                name: "SignUpId",
                table: "MoreDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SignUpId",
                table: "Items",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ItemCategoryId",
                table: "Items",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_MoreDetails_SignUpId",
                table: "MoreDetails",
                column: "SignUpId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SignUpId",
                table: "Items",
                column: "SignUpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategories_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId",
                principalTable: "ItemCategories",
                principalColumn: "ItemCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_SignUps_SignUpId",
                table: "Items",
                column: "SignUpId",
                principalTable: "SignUps",
                principalColumn: "SignUpId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MoreDetails_SignUps_SignUpId",
                table: "MoreDetails",
                column: "SignUpId",
                principalTable: "SignUps",
                principalColumn: "SignUpId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
