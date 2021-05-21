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
                    { 1L, "First event", new DateTime(2021, 5, 21, 1, 44, 5, 492, DateTimeKind.Local).AddTicks(9170), new DateTime(2021, 5, 21, 0, 44, 5, 469, DateTimeKind.Local).AddTicks(9210) },
                    { 2L, "Second event", new DateTime(2021, 5, 21, 2, 44, 5, 493, DateTimeKind.Local).AddTicks(2990), new DateTime(2021, 5, 21, 0, 44, 5, 493, DateTimeKind.Local).AddTicks(2010) },
                    { 3L, "Third event", new DateTime(2021, 5, 21, 3, 44, 5, 493, DateTimeKind.Local).AddTicks(3020), new DateTime(2021, 5, 21, 0, 44, 5, 493, DateTimeKind.Local).AddTicks(3010) }
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
