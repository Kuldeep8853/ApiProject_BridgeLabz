﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.UserContext;

namespace Repository.Migrations
{
    [DbContext(typeof(UserContextDB))]
    partial class UserContextDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Parking", b =>
                {
                    b.Property<int>("ParkingSlotNo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChargesPerHour");

                    b.Property<string>("DriverCategory")
                        .IsRequired();

                    b.Property<DateTime>("EntryTime");

                    b.Property<string>("ParkingType")
                        .IsRequired();

                    b.Property<string>("VehicalNo")
                        .IsRequired();

                    b.Property<string>("VehicalType")
                        .IsRequired();

                    b.HasKey("ParkingSlotNo");

                    b.ToTable("ParkingSpace");
                });
#pragma warning restore 612, 618
        }
    }
}
