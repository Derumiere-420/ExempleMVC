﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeneriqueCRUD.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240621171350_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GeneriqueCRUD.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hammer",
                            Price = 12m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Screwdriver",
                            Price = 8m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wrench",
                            Price = 15m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Pliers",
                            Price = 7m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Saw",
                            Price = 22m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Drill",
                            Price = 45m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Tape Measure",
                            Price = 5m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Level",
                            Price = 9m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Chisel",
                            Price = 6m
                        },
                        new
                        {
                            Id = 10,
                            Name = "Allen Wrench Set",
                            Price = 12m
                        });
                });

            modelBuilder.Entity("GeneriqueCRUD.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
