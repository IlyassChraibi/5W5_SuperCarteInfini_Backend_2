using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperCarteInfiniMVC.Data.Migrations
{
    public partial class newSeed5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "81ccc4af-1210-418c-b9fa-9b421e9ef957");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "480452df-53c4-4af4-99ff-393cc1826c61", "AQAAAAEAACcQAAAAEGiLUfF1vfpkBHuLoBdK/EROu8ByeQFJS+W/gNViIXdS1O0W/x/chOO5JQ3UxsU1gg==", "1a432e91-2a67-4511-83d4-a96ddb41bd90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da8858a6-5340-4fe3-b5c6-7792f13fce05", "AQAAAAEAACcQAAAAEKPTSqShmHbL6sYLhvJD/w9o5ApdqRw5aJfOdYjaCbTQ2w4vDyHf7e7vfAKqRbsA7g==", "4bca0e1e-ad9d-43b6-bb3d-d32da483d02b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "52d2fe50-c6b3-4089-8793-4818ff500b41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a20e6c6-61f0-4312-a614-85dd7d298948", "AQAAAAEAACcQAAAAEBi8cExDWsNO4B5bOhrdLowdkXL3ZwmHEZaAxx777tMEqrifJT6BYOokWhJW3tB2mg==", "6996fac4-1b88-472a-b233-a021b7bc4d76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71d5a9af-56cc-4986-bd2d-827392a622dc", "AQAAAAEAACcQAAAAEKEdAlQ8mqslzzqZcoG4IJ7lW5mQtI/7FFNEu8z44zZN5O19StvULkCu29J4lG5M4w==", "0356395f-f967-450b-b157-032cf8cc264e" });
        }
    }
}
