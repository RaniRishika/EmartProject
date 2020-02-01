using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartApplication.Migrations.EmartItem
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Ino = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Noi = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(nullable: true),
                    Sname = table.Column<string>(nullable: true),
                    Scid = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Cid = table.Column<int>(nullable: false),
                    Cname = table.Column<string>(nullable: true),
                    Scname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Ino);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Scid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cid = table.Column<int>(nullable: false),
                    Cname = table.Column<string>(nullable: true),
                    Scname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Scid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "SubCategory");
        }
    }
}
