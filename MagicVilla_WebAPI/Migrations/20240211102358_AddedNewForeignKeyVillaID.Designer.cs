﻿// <auto-generated />
using System;
using MagicVilla_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240211102358_AddedNewForeignKeyVillaID")]
    partial class AddedNewForeignKeyVillaID
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_WebAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("SqFt")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6210),
                            Details = "aasdf asd  asdf asdf",
                            ImageUrl = "",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 500.0,
                            SqFt = 550,
                            UpdatedDate = new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6219)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6221),
                            Details = "aasdf asd  asdf asdf",
                            ImageUrl = "",
                            Name = "Royal Villa 2",
                            Occupancy = 5,
                            Rate = 500.0,
                            SqFt = 550,
                            UpdatedDate = new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6221)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6223),
                            Details = "aasdf asd  asdf asdf",
                            ImageUrl = "",
                            Name = "Royal Villa 3",
                            Occupancy = 5,
                            Rate = 500.0,
                            SqFt = 550,
                            UpdatedDate = new DateTime(2024, 2, 11, 15, 23, 58, 651, DateTimeKind.Local).AddTicks(6224)
                        });
                });

            modelBuilder.Entity("MagicVilla_WebAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaID")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("MagicVilla_WebAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_WebAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}