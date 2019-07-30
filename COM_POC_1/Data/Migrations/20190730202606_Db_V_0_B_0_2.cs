using Microsoft.EntityFrameworkCore.Migrations;

namespace COM_POC_1.Migrations
{
    public partial class Db_V_0_B_0_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Archetype",
                table: "Themes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "McId", "Name" },
                values: new object[] { 1, null, "Dinas Niwl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Archetype",
                table: "Themes");
        }
    }
}
