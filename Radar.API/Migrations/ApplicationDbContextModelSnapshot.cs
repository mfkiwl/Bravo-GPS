﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Radar.Library.Data;

namespace Radar.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Radar.Library.Models.Entity.Alert", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AlertColour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AlertTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("AlertType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<float>("VehicleHumidity")
                        .HasColumnType("real");

                    b.Property<Guid>("VehicleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("VehicleTemp")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Alerts");
                });

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
