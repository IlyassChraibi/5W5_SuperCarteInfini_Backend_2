using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperCarteInfiniMVC.Data.Migrations
{
    public partial class newSeed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Players_PlayerId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_PlayerId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Cards");

            migrationBuilder.CreateTable(
                name: "OwnedCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCard_CardId",
                table: "OwnedCard",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnedCard_PlayerId",
                table: "OwnedCard",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OwnedCard");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Cards",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PlayerId",
                table: "Cards",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Players_PlayerId",
                table: "Cards",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
