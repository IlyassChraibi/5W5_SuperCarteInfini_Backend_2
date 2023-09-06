using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperCarteInfiniMVC.Data.Migrations
{
    public partial class newSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "2f45974b-eceb-4763-9b83-d2beb597da73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b8e8ca5-45bb-492e-8d30-0e78fa4e1731", "AQAAAAEAACcQAAAAEAKLhoB/yL5A1S/ELspA97RBxJV5So6hM+WC+8XbFrePpqBP9o2Q+MtW0v1YOJUK0A==", "d909d875-60c6-4789-9d92-791d86088114" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b09e88fa-01e4-4645-aa29-3028a03b64af", "AQAAAAEAACcQAAAAEAxXV7LCYciFD4V2Q/uOa2vBdIj6TNEPdnS5/bbKUS88XxTCNHPGc10rwZpp6XOnWQ==", "e611c510-f77a-4880-88d7-c196f27a0b8c" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "IdentityUserId", "Money", "Name" },
                values: new object[] { 1, "11111111-1111-1111-1111-111111111112", 100, "Tester" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "73a10dcf-2b01-43c0-a240-7cd98474d444");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9df5dd9-58a2-4356-9b5a-b88d159c65b2", "AQAAAAEAACcQAAAAEGhJ64O80w8Dn6t6DnI49ICTDIhe6pfSTTuW/EB8MQvRzwmPfKTxLCTdBcG3OxwmcQ==", "935e1590-c7fb-4b7a-830c-b91675c99993" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb8d1136-5c8e-490d-86ec-87daaf12cf9b", "AQAAAAEAACcQAAAAEMN4fcyWjbL2xjIUqi16MOL4Gemjghbjg1tfDYBOdWS8HMwAv9DIA2YhQXOhZxjSNA==", "8f3189af-1311-4e7c-bfc9-53724eadb441" });
        }
    }
}
