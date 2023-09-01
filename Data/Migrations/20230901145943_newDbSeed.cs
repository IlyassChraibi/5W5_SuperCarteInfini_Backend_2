using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperCarteInfiniMVC.Data.Migrations
{
    public partial class newDbSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ad2024b3-1e06-4d62-ae56-c97112581265");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11111111-1111-1111-1111-111111111113", "d0e27c28-d733-41a9-96cb-d58615275b7f", "Admin", "ADMIN" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11111111-1111-1111-1111-111111111113", "11111111-1111-1111-1111-111111111111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11111111-1111-1111-1111-111111111113", "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1f77c6d7-bff9-475b-963d-072cdb27c0cd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "c9b2f8d2-80c2-4f31-ba67-f23a0edf3a55", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5baa2d01-ebb7-414f-bf69-bcd074b11bf9", "AQAAAAEAACcQAAAAEJgCYi3+P6+/GRO2FddG9+LavKrzkCJXJSzIL4wEWF/EZ0IlURINZfGoSv/mZguFhw==", "fcb00616-e715-444d-8d38-bdd6db9e4235" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a06b4eb-de76-4a6a-bfdb-fa3313226da4", "AQAAAAEAACcQAAAAEN/kzkOqzNHB70YCwaNb/BCholgo3rubi+HMcHdq+teO37WUzlVkTvS6oPyizUyX4Q==", "10f11e66-518a-40db-951a-5a60194fbc6e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "11111111-1111-1111-1111-111111111111" });
        }
    }
}
