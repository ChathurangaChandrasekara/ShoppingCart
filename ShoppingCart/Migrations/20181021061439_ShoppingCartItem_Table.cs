using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCart.Migrations
{
    public partial class ShoppingCartItem_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Items_ItemId",
                table: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "SignUpDTO");

            migrationBuilder.DropColumn(
                name: "ItemCode",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "signUpId",
                table: "ShoppingCartItems");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "ShoppingCartItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Items_ItemId",
                table: "ShoppingCartItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Items_ItemId",
                table: "ShoppingCartItems");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId",
                table: "ShoppingCartItems",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemCode",
                table: "ShoppingCartItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "ShoppingCartItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitPrice",
                table: "ShoppingCartItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "signUpId",
                table: "ShoppingCartItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SignUpDTO",
                columns: table => new
                {
                    SignUpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: true),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: false),
                    LoginType = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignUpDTO", x => x.SignUpId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Items_ItemId",
                table: "ShoppingCartItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
