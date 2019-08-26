using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWorkCore.Data.Migrations
{
    public partial class SeedSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { "1", "back-ground-color", "red" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
