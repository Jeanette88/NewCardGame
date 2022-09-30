using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewCardGame.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Suit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItsOK = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Card",
                columns: new[] { "Id", "Image", "ItsOK", "Name", "Suit", "Value" },
                values: new object[,]
                {
                    { new Guid("002e8179-dae8-48e0-90d0-98616ac415ad"), null, false, "ten diamonds", "D", 10 },
                    { new Guid("0c9eafe8-796c-47f8-a2c4-98b1ed6b8594"), null, false, "eight clubs", "C", 8 },
                    { new Guid("131531af-4780-4353-89f9-4bd912acaea2"), null, false, "king clubs", "C", 13 },
                    { new Guid("17260e2c-29e1-40d5-8644-9fb90550c846"), null, false, "king hearts", "H", 13 },
                    { new Guid("1affa909-0d49-4416-bd36-1755174b4d44"), null, false, "ten spades", "S", 10 },
                    { new Guid("1dcbcf94-11a0-45b8-b8fa-301303bb8597"), null, false, "three clubs", "C", 3 },
                    { new Guid("1f5873d4-d3cf-45c5-8eb0-9c5522bcce7b"), null, false, "jack clubs", "C", 11 },
                    { new Guid("236ba3d4-2d1d-4a9d-a4d5-01f94b6364bd"), null, false, "two clubs", "C", 2 },
                    { new Guid("38c94d1c-77a4-4905-a6be-3cbab449dc8e"), null, false, "seven clubs", "C", 7 },
                    { new Guid("53166a74-02a2-453d-9008-e663878646c1"), null, false, "nine clubs", "C", 9 },
                    { new Guid("668a3a70-3017-486c-9f69-81f9bd63f4a0"), null, false, "ten clubs", "C", 10 },
                    { new Guid("c856f539-4e1e-42e4-b6e2-dd88b0df8f04"), null, false, "queen clubs", "C", 12 },
                    { new Guid("d0b27ce1-5b43-4a2a-b2fb-7288824a4d85"), null, false, "five clubs", "C", 5 },
                    { new Guid("d936ec3a-6e43-4558-88d9-775d934667c7"), null, false, "ace clubs", "C", 1 },
                    { new Guid("e5445d3d-5152-4163-a18b-16f6576e3ecd"), null, false, "six clubs", "C", 6 },
                    { new Guid("f1883297-e207-4818-a2ed-70b6ea208323"), null, false, "four clubs", "C", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
