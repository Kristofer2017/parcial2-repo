using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial02.Migrations
{
    public partial class Change01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SecurityQuestions",
                columns: new[] { "id", "question" },
                values: new object[] { 1, "What year were you born?" });

            migrationBuilder.InsertData(
                table: "SecurityQuestions",
                columns: new[] { "id", "question" },
                values: new object[] { 2, "What was your first pet's name?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SecurityQuestions",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SecurityQuestions",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
