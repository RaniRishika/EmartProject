using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Phno = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Cpwd = table.Column<string>(nullable: true),
                    CompName = table.Column<string>(nullable: true),
                    Gstin = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seller");
        }
    }
}
