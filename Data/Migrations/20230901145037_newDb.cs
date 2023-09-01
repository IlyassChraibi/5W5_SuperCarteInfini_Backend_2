using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperCarteInfiniMVC.Data.Migrations
{
    public partial class newDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defense = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "c9b2f8d2-80c2-4f31-ba67-f23a0edf3a55", "Admin", "ADMIN" },
                    { "2", "1f77c6d7-bff9-475b-963d-072cdb27c0cd", "Player", "PLAYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11111111-1111-1111-1111-111111111111", 0, "5baa2d01-ebb7-414f-bf69-bcd074b11bf9", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJgCYi3+P6+/GRO2FddG9+LavKrzkCJXJSzIL4wEWF/EZ0IlURINZfGoSv/mZguFhw==", null, false, "fcb00616-e715-444d-8d38-bdd6db9e4235", false, "admin@admin.com" },
                    { "11111111-1111-1111-1111-111111111112", 0, "4a06b4eb-de76-4a6a-bfdb-fa3313226da4", "player@player.com", true, false, null, "PLAYER@PLAYER.COM", "PLAYER@PLAYER.COM", "AQAAAAEAACcQAAAAEN/kzkOqzNHB70YCwaNb/BCholgo3rubi+HMcHdq+teO37WUzlVkTvS6oPyizUyX4Q==", null, false, "10f11e66-518a-40db-951a-5a60194fbc6e", false, "player@player.com" }
                });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "Attack", "Defense", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 1, 2, "dijdjj", "A" },
                    { 2, 2, 1, "dijdjj", "B" },
                    { 3, 2, 2, "dijdjj", "C" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "11111111-1111-1111-1111-111111111112" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "11111111-1111-1111-1111-111111111112" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112");
        }
    }
}
