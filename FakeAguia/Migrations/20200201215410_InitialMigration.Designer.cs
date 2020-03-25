﻿// <auto-generated />
using System;
using FakeAguia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FakeAguia.Migrations
{
    [DbContext(typeof(FakeAguiaContext))]
    [Migration("20200201215410_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FakeAguia.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("PlantId");

                    b.Property<int>("Profile");

                    b.Property<int?>("RoleId");

                    b.Property<int?>("ShiftId");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.HasIndex("RoleId");

                    b.HasIndex("ShiftId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("FakeAguia.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("RegionId");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Plant");
                });

            modelBuilder.Entity("FakeAguia.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("FakeAguia.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("FakeAguia.Models.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BeginsAt");

                    b.Property<DateTime>("EndsAt");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Shift");
                });

            modelBuilder.Entity("FakeAguia.Models.Employee", b =>
                {
                    b.HasOne("FakeAguia.Models.Plant", "Plant")
                        .WithMany()
                        .HasForeignKey("PlantId");

                    b.HasOne("FakeAguia.Models.Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId");

                    b.HasOne("FakeAguia.Models.Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId");
                });

            modelBuilder.Entity("FakeAguia.Models.Plant", b =>
                {
                    b.HasOne("FakeAguia.Models.Region", "Region")
                        .WithMany("Plants")
                        .HasForeignKey("RegionId");
                });
#pragma warning restore 612, 618
        }
    }
}