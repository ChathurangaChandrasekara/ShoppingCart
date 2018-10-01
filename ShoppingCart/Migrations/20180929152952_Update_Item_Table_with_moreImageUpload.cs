using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCart.Migrations
{
    public partial class Update_Item_Table_with_moreImageUpload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Items",
                newName: "ImageUrl4");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl1",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl2",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl3",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemCategoryDTO",
                columns: table => new
                {
                    ItemCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemCategoryName = table.Column<string>(nullable: true),
                    SignUpId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategoryDTO", x => x.ItemCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "SignUpDTO",
                columns: table => new
                {
                    SignUpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: true),
                    LoginType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignUpDTO", x => x.SignUpId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemCategoryDTO");

            migrationBuilder.DropTable(
                name: "SignUpDTO");

            migrationBuilder.DropColumn(
                name: "ImageUrl1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ImageUrl2",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ImageUrl3",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ImageUrl4",
                table: "Items",
                newName: "ImageUrl");
        }
    }
}
