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
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(nullable: true),
                    MainImage = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
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
                values: new object[] { new Guid("8d948780-eb93-4b48-923a-555c44288fb1"), "chakalaka", "Boom Boom", "123AZERTY", "ChakBoom" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "City", "Country", "CreatorId", "Description", "EndDateTime", "EventName", "LocationLat", "LocationLng", "MainImage", "Number", "StartDateTime", "Street" },
                values: new object[] { 1L, "Tielt", "Belgium", new Guid("8d948780-eb93-4b48-923a-555c44288fb1"), "test event tielt", new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test1", 0.0, 0.0, "paris.jpg", "3", new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sint Janstraat" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "City", "Country", "CreatorId", "Description", "EndDateTime", "EventName", "LocationLat", "LocationLng", "MainImage", "Number", "StartDateTime", "Street" },
                values: new object[] { 2L, "Brugge", "Belgium", new Guid("8d948780-eb93-4b48-923a-555c44288fb1"), "Test Event Brugge", new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test2", 0.0, 0.0, "paris.jpg", "3", new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rijselstraat" });

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
