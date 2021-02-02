﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Radar.Library.Data;

namespace Radar.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210202140450_AndrewMigration")]
    partial class AndrewMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Radar.Library.Vehicle", b =>
                {
                    b.Property<Guid>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<float>("VehicleHumidity")
                        .HasColumnType("real");

                    b.Property<float>("VehicleTemp")
                        .HasColumnType("real");

                    b.HasKey("VehicleID");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
