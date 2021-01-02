﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCoreAPI;

namespace NETCoreAPI.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20210102172739_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NETCoreAPI.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Name = "Mico Yuk"
                        },
                        new
                        {
                            AuthorId = 2,
                            Name = "Arlan Hamilton"
                        },
                        new
                        {
                            AuthorId = 3,
                            Name = "Minda Harts"
                        },
                        new
                        {
                            AuthorId = 4,
                            Name = "Susanne Tedrick"
                        },
                        new
                        {
                            AuthorId = 5,
                            Name = "Abisoye Ajayi-Akinfolarin"
                        },
                        new
                        {
                            AuthorId = 6,
                            Name = "Kesha Williams"
                        });
                });

            modelBuilder.Entity("NETCoreAPI.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            Title = "Data Visualization for Dummies"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            Title = "It's About Damn Time"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 3,
                            Title = "The Memo"
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 4,
                            Title = "Women of Color in Tech"
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 5,
                            Title = "I WOKE UP AT 30: How I Utilised Inertia for Global Impact"
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 6,
                            Title = "No books but check out her Pluralsight courses!"
                        });
                });

            modelBuilder.Entity("NETCoreAPI.Book", b =>
                {
                    b.HasOne("NETCoreAPI.Author", null)
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
