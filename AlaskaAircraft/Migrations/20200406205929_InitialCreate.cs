using Microsoft.EntityFrameworkCore.Migrations;

namespace AlaskaAircraft.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircraft",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 6, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tail_Number = table.Column<string>(nullable: true),
                    LRU_Name = table.Column<string>(nullable: true),
                    LRU_Part_Number = table.Column<string>(nullable: true),
                    Software_Name = table.Column<string>(nullable: true),
                    Software_Part_Number = table.Column<string>(nullable: true),
                    EC_Number = table.Column<string>(nullable: true),
                    Pre_Post_Condition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aircraft");
        }
    }
}
