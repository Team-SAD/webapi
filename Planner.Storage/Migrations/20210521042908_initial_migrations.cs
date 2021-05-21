using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Planner.Storage.Migrations
{
    public partial class initial_migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Discription = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Street = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    Zipcode = table.Column<string>(type: "text", nullable: true)
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
                    { 1L, "First event", new DateTime(2021, 5, 21, 1, 29, 7, 556, DateTimeKind.Local).AddTicks(8800), new DateTime(2021, 5, 21, 0, 29, 7, 533, DateTimeKind.Local).AddTicks(9380) },
                    { 2L, "Second event", new DateTime(2021, 5, 21, 2, 29, 7, 557, DateTimeKind.Local).AddTicks(2380), new DateTime(2021, 5, 21, 0, 29, 7, 557, DateTimeKind.Local).AddTicks(1560) },
                    { 3L, "Third event", new DateTime(2021, 5, 21, 3, 29, 7, 557, DateTimeKind.Local).AddTicks(2410), new DateTime(2021, 5, 21, 0, 29, 7, 557, DateTimeKind.Local).AddTicks(2400) }
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
