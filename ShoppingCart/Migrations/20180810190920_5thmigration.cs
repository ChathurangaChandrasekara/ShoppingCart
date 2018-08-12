using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCart.Migrations
{
    public partial class _5thmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignUpDTO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
