using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperCarteInfiniMVC.Migrations
{
    public partial class ownedcards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Card",
                table: "Card");

            migrationBuilder.RenameTable(
                name: "Card",
                newName: "Cards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Money = table.Column<int>(type: "INTEGER", nullable: false),
                    IdentityUserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnedCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnedCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OwnedCard_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnedCard_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11111111-1111-1111-1111-111111111113", "801bd2e4-cfb8-4035-ae1d-6e67f8165211", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "11111111-1111-1111-1111-111111111111", 0, "5f377134-be20-4ac7-8ad2-ae5a41f07aeb", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGStAUfzVqYlasR/pHNapxmeV8XRrlCfBFIY8SwDBb/4cyl3q35heudgSrUJKLFICg==", null, false, "2a5d2014-9f60-4f9d-9d69-f9bba1e34365", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "11111111-1111-1111-1111-111111111112", 0, "94fe3d72-2474-4a03-87af-56c89de1300b", "player@player.com", true, false, null, "PLAYER@PLAYER.COM", "PLAYER@PLAYER.COM", "AQAAAAEAACcQAAAAEM0QVxsGwq0jHzvj8jtqAwcaTwBtCBQSvELEBWWhKkefHAd3MslrGqkmGsf04ldPSA==", null, false, "7e11329b-aec3-4cab-b2cf-2be8607cfc69", false, "player@player.com" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Attack", "Defense", "ImageUrl", "Name" },
                values: new object[] { 1, 1, 2, "dijdjj", "A" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Attack", "Defense", "ImageUrl", "Name" },
                values: new object[] { 2, 2, 1, "dijdjj", "B" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Attack", "Defense", "ImageUrl", "Name" },
                values: new object[] { 3, 2, 2, "dijdjj", "C" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "11111111-1111-1111-1111-111111111113", "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "IdentityUserId", "Money", "Name" },
                values: new object[] { 1, "11111111-1111-1111-1111-111111111112", 100, "Tester" });

            migrationBuilder.InsertData(
                table: "OwnedCard",
                columns: new[] { "Id", "CardId", "PlayerId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "OwnedCard",
                columns: new[] { "Id", "CardId", "PlayerId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "OwnedCard",
                columns: new[] { "Id", "CardId", "PlayerId" },
                values: new object[] { 3, 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCard_CardId",
                table: "OwnedCard",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCard_PlayerId",
                table: "OwnedCard",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_IdentityUserId",
                table: "Players",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OwnedCard");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11111111-1111-1111-1111-111111111113", "11111111-1111-1111-1111-111111111111" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "Card");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                column: "Id");
        }
    }
}
