﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Planner.Storage;

namespace Planner.Storage.Migrations
{
    [DbContext(typeof(CPContext))]
    partial class CPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Planner.Domain.Models.Customer", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Name = "Abdul-Rauf Yakubu"
                        },
                        new
                        {
                            EntityId = 2L,
                            Name = "Daniel Henderson"
                        },
                        new
                        {
                            EntityId = 3L,
                            Name = "Stanhope Nwosu"
                        },
                        new
                        {
                            EntityId = 4L,
                            Name = "Fred Belotte"
                        },
                        new
                        {
                            EntityId = 5L,
                            Name = "Azhya Knox"
                        });
                });

            modelBuilder.Entity("Planner.Domain.Models.Event", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discription")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("EntityId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            Discription = "First event",
                            EndDate = new DateTime(2021, 5, 21, 1, 4, 4, 516, DateTimeKind.Local).AddTicks(1330),
                            StartDate = new DateTime(2021, 5, 21, 0, 4, 4, 493, DateTimeKind.Local).AddTicks(1780)
                        },
                        new
                        {
                            EntityId = 2L,
                            Discription = "Second event",
                            EndDate = new DateTime(2021, 5, 21, 2, 4, 4, 516, DateTimeKind.Local).AddTicks(4870),
                            StartDate = new DateTime(2021, 5, 21, 0, 4, 4, 516, DateTimeKind.Local).AddTicks(4070)
                        },
                        new
                        {
                            EntityId = 3L,
                            Discription = "Third event",
                            EndDate = new DateTime(2021, 5, 21, 3, 4, 4, 516, DateTimeKind.Local).AddTicks(4900),
                            StartDate = new DateTime(2021, 5, 21, 0, 4, 4, 516, DateTimeKind.Local).AddTicks(4900)
                        });
                });

            modelBuilder.Entity("Planner.Domain.Models.Location", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<string>("Zipcode")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
