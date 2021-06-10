using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial02.Migrations
{
    public partial class Change2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "id", "faculty" },
                values: new object[,]
                {
                    { 1, "Architecture and Engineering" },
                    { 2, "Social Sciences and Humanities" },
                    { 3, "Economic and Business Sciences" }
                });

            migrationBuilder.InsertData(
                table: "securityQuestions",
                columns: new[] { "id", "question" },
                values: new object[,]
                {
                    { 1, "What year were you born?" },
                    { 2, "What was your first pet's name?" },
                    { 3, "What college did you graduate from?" },
                    { 4, "What's your favorite movie's name?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "securityQuestions",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "securityQuestions",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "securityQuestions",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "securityQuestions",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
