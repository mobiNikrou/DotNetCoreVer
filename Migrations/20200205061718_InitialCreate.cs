using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreVer1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestingResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TestCheck1 = table.Column<string>(nullable: true),
                    TestCheck2 = table.Column<string>(nullable: true),
                    TestCheck3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestingResult", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestingResult");
        }
    }
}
