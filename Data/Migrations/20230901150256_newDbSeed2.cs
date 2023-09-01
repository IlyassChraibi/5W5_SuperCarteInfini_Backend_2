using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperCarteInfiniMVC.Data.Migrations
{
    public partial class newDbSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "a6089375-a542-40ed-81b4-9df2a708a40a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4b6f3443-a165-4af1-8678-04013ac60719");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "612d05b7-fca4-4031-9f2d-df8f3c414888", "AQAAAAEAACcQAAAAEEYJ4Tp73LyHe7gmd8F1d4RgT6VSxt0qf6L7MBAdSWhHuPkl8kO99qG8OEJkcpRgNw==", "94fda033-3a49-4e17-87bc-5e9e96accded" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf7157d-cdd9-4ac3-a5cb-72cbbca74d2c", "AQAAAAEAACcQAAAAEAADpSCwfMwzRrnobllY0biint10UqPUiO59K0kpMCB+EZ/rYgVVo4hLZRe7+ywkqg==", "418fd52f-9fa2-49cd-bd3a-056a8e09ef51" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "d0e27c28-d733-41a9-96cb-d58615275b7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ad2024b3-1e06-4d62-ae56-c97112581265");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32d53aeb-f7e8-4282-a8a1-ef3c064f0620", "AQAAAAEAACcQAAAAEHeQfYNkEEJGoPh5G+Di9uSQYBPZyzvwVbzYnkONMoMUf15yuByFHWkfN5ShnS1j6Q==", "6e5f1f71-366a-470a-b622-5f200bf5892c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8416a2c-bcf9-42b5-98ed-bff9c1be4758", "AQAAAAEAACcQAAAAENW/4gODnv9B+gJdjcZHhTgryi/bYG3zNEBSE+PA1RzMNHTWvJuPIn6+Xt1tK6yyHw==", "a76950a3-517e-4632-8351-e1f4a61cf25f" });
        }
    }
}
