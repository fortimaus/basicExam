using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asp.Migrations
{
    /// <inheritdoc />
    public partial class updateInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "login", "password", "trainingId" },
                values: new object[] { 1, "admin", "admin", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
