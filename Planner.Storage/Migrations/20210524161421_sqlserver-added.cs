using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Planner.Storage.Migrations
{
    public partial class sqlserveradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EntityId);
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { 1L, "Abdul-Rauf Yakubu" },
                    { 2L, "Daniel Henderson" },
                    { 3L, "Stanhope Nwosu" },
                    { 4L, "Fred Belotte" },
                    { 5L, "Azhya Knox" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EntityId", "Discription", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { 1L, "First event", new DateTime(2021, 5, 24, 13, 14, 20, 481, DateTimeKind.Local).AddTicks(9360), new DateTime(2021, 5, 24, 12, 14, 20, 458, DateTimeKind.Local).AddTicks(8000) },
                    { 2L, "Second event", new DateTime(2021, 5, 24, 14, 14, 20, 482, DateTimeKind.Local).AddTicks(2670), new DateTime(2021, 5, 24, 12, 14, 20, 482, DateTimeKind.Local).AddTicks(2030) },
                    { 3L, "Third event", new DateTime(2021, 5, 24, 15, 14, 20, 482, DateTimeKind.Local).AddTicks(2700), new DateTime(2021, 5, 24, 12, 14, 20, 482, DateTimeKind.Local).AddTicks(2690) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
