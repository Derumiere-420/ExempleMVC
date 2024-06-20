﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace OverPosting.Migrations
{
    [DbContext(typeof(MyDbController))]
    [Migration("20240619231300_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OverPosting.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilisateur");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alice.dupont@example.com",
                            EstAdmin = false,
                            Nom = "Alice Dupont"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob.martin@example.com",
                            EstAdmin = false,
                            Nom = "Bob Martin"
                        },
                        new
                        {
                            Id = 3,
                            Email = "charlie.durand@example.com",
                            EstAdmin = false,
                            Nom = "Charlie Durand"
                        },
                        new
                        {
                            Id = 4,
                            Email = "david.leroy@example.com",
                            EstAdmin = false,
                            Nom = "David Leroy"
                        },
                        new
                        {
                            Id = 5,
                            Email = "eva.bernard@example.com",
                            EstAdmin = false,
                            Nom = "Eva Bernard"
                        },
                        new
                        {
                            Id = 6,
                            Email = "franck.dubois@example.com",
                            EstAdmin = false,
                            Nom = "Franck Dubois"
                        },
                        new
                        {
                            Id = 7,
                            Email = "gina.moreau@example.com",
                            EstAdmin = false,
                            Nom = "Gina Moreau"
                        },
                        new
                        {
                            Id = 8,
                            Email = "hugo.petit@example.com",
                            EstAdmin = false,
                            Nom = "Hugo Petit"
                        },
                        new
                        {
                            Id = 9,
                            Email = "isabelle.thomas@example.com",
                            EstAdmin = false,
                            Nom = "Isabelle Thomas"
                        },
                        new
                        {
                            Id = 10,
                            Email = "julien.fontaine@example.com",
                            EstAdmin = false,
                            Nom = "Julien Fontaine"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
