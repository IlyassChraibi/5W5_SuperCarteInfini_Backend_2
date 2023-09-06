using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperCarteInfiniMVC.Data.Migrations
{
    public partial class newSeed4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "3937e2db-27b8-434e-a1e6-a683e7a04518");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f0466e5-8ceb-4b26-a0c0-69f3b71e2a16", "AQAAAAEAACcQAAAAEG4wXfZ9DWlGETf4cQbn3kgI1QGptOGsll08j8ifSZZ9JhrGB0fYxAn+zlJfK3J+1w==", "21b278d3-3f44-41e2-8c9c-7521cb363ebd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a8faaa6-89a7-430a-9d63-4ec7a6fd8d0d", "AQAAAAEAACcQAAAAEAHF5m6Yfy15bp4yDIfLHNXHwyUQxbXBf4VQ4eSh2KRSvmxpHm5foGQD+elzaERrOg==", "9477ac5e-e3fd-4c21-bc7d-e4b6a4578433" });
        }
    }
}
