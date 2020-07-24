using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class seedvalue1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "tushar" });

            migrationBuilder.InsertData(
                table: "values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "raj" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "values",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "values",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
