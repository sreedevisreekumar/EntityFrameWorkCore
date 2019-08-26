using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameWorkCore.Data.Migrations
{
    public partial class SeedSettingsChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1",
                column: "Value",
                value: "green");

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[] { "2", "border", "solid 1px black" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: "1",
                column: "Value",
                value: "red");
        }
    }
}
