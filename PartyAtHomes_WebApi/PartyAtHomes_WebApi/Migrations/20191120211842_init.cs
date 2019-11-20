using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PartyAtHomes_WebApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EventName = table.Column<string>(nullable: true),
                    MainImage = table.Column<string>(nullable: true),
                    AdressCity = table.Column<string>(nullable: true),
                    AdressCountry = table.Column<string>(nullable: true),
                    AdressStreet = table.Column<string>(nullable: true),
                    AdressNumber = table.Column<string>(nullable: true),
                    DescriptionEvent = table.Column<string>(nullable: true),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    LocationLat = table.Column<double>(nullable: false),
                    LocationLng = table.Column<double>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { new Guid("2e6b0565-4412-431f-bab3-37c7fcdb725e"), "chakalaka", "Boom Boom", "123AZERTY", "ChakBoom" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AdressCity", "AdressCountry", "AdressNumber", "AdressStreet", "CreatorId", "DescriptionEvent", "EndDateTime", "EventName", "LocationLat", "LocationLng", "MainImage", "StartDateTime" },
                values: new object[] { new Guid("6c1c3a63-834a-4d14-b040-fa41a02e1071"), "Tielt", "Belgium", "3", null, new Guid("2e6b0565-4412-431f-bab3-37c7fcdb725e"), "Test Event", new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", 0.0, 0.0, null, new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CreatorId",
                table: "Events",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
