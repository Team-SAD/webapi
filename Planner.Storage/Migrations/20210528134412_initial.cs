using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Planner.Storage.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserEntityId = table.Column<long>(type: "bigint", nullable: true),
                    LocationEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Events_AppUsers_AppUserEntityId",
                        column: x => x.AppUserEntityId,
                        principalTable: "AppUsers",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Locations_LocationEntityId",
                        column: x => x.LocationEntityId,
                        principalTable: "Locations",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "EntityId", "EventId", "Name" },
                values: new object[,]
                {
                    { 1L, 0L, "Abdul-Rauf Yakubu" },
                    { 2L, 0L, "Daniel Henderson" },
                    { 3L, 0L, "Stanhope Nwosu" },
                    { 4L, 0L, "Fred Belotte" },
                    { 5L, 0L, "Azhya Knox" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EntityId", "AppUserEntityId", "Description", "EndDate", "LocationEntityId", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1L, null, "First event", new DateTime(2021, 5, 28, 10, 44, 11, 523, DateTimeKind.Local).AddTicks(3230), null, new DateTime(2021, 5, 28, 9, 44, 11, 501, DateTimeKind.Local).AddTicks(5030), "Title 1" },
                    { 2L, null, "Second event", new DateTime(2021, 5, 28, 11, 44, 11, 523, DateTimeKind.Local).AddTicks(7110), null, new DateTime(2021, 5, 28, 9, 44, 11, 523, DateTimeKind.Local).AddTicks(6610), "Title 2" },
                    { 3L, null, "Third event", new DateTime(2021, 5, 28, 12, 44, 11, 523, DateTimeKind.Local).AddTicks(7260), null, new DateTime(2021, 5, 28, 9, 44, 11, 523, DateTimeKind.Local).AddTicks(7250), "Title 3" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "EntityId", "City", "State", "Street", "Zipcode" },
                values: new object[,]
                {
                    { 1L, "City 1", "State 1", "Street 1", "45623" },
                    { 2L, "City 2", "State 2", "Street 2", "45643" },
                    { 3L, "City ", "State 3", "Street 3", "45643" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_AppUserEntityId",
                table: "Events",
                column: "AppUserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_LocationEntityId",
                table: "Events",
                column: "LocationEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
