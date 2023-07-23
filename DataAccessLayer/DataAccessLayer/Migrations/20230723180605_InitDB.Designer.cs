﻿// <auto-generated />
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(StockContext))]
    [Migration("20230723180605_InitDB")]
    partial class InitDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccessLayer.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StockID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Stock", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Vianet",
                            Price = 10m
                        },
                        new
                        {
                            ID = 2,
                            Name = "Agritek",
                            Price = 10m
                        },
                        new
                        {
                            ID = 3,
                            Name = "Akamai",
                            Price = 10m
                        },
                        new
                        {
                            ID = 4,
                            Name = "Baidu",
                            Price = 10m
                        },
                        new
                        {
                            ID = 5,
                            Name = "Blinkx",
                            Price = 10m
                        },
                        new
                        {
                            ID = 6,
                            Name = "Blucora",
                            Price = 10m
                        },
                        new
                        {
                            ID = 7,
                            Name = "Boingo",
                            Price = 10m
                        },
                        new
                        {
                            ID = 8,
                            Name = "Brainybrawn",
                            Price = 10m
                        },
                        new
                        {
                            ID = 9,
                            Name = "Carbonite",
                            Price = 10m
                        },
                        new
                        {
                            ID = 10,
                            Name = "China Finance",
                            Price = 10m
                        },
                        new
                        {
                            ID = 11,
                            Name = "ChinaCache",
                            Price = 10m
                        },
                        new
                        {
                            ID = 12,
                            Name = "ADR",
                            Price = 10m
                        },
                        new
                        {
                            ID = 13,
                            Name = "ChitrChatr",
                            Price = 10m
                        },
                        new
                        {
                            ID = 14,
                            Name = "Cnova",
                            Price = 10m
                        },
                        new
                        {
                            ID = 15,
                            Name = "Cogent",
                            Price = 10m
                        },
                        new
                        {
                            ID = 16,
                            Name = "Crexendo",
                            Price = 10m
                        },
                        new
                        {
                            ID = 17,
                            Name = "CrowdGather",
                            Price = 10m
                        },
                        new
                        {
                            ID = 18,
                            Name = "EarthLink",
                            Price = 10m
                        },
                        new
                        {
                            ID = 19,
                            Name = "Eastern",
                            Price = 10m
                        },
                        new
                        {
                            ID = 20,
                            Name = "ENDEXX",
                            Price = 10m
                        },
                        new
                        {
                            ID = 21,
                            Name = "Envestnet",
                            Price = 10m
                        },
                        new
                        {
                            ID = 22,
                            Name = "Epazz",
                            Price = 10m
                        },
                        new
                        {
                            ID = 23,
                            Name = "FlashZero",
                            Price = 10m
                        },
                        new
                        {
                            ID = 24,
                            Name = "Genesis",
                            Price = 10m
                        },
                        new
                        {
                            ID = 25,
                            Name = "InterNAP",
                            Price = 10m
                        },
                        new
                        {
                            ID = 26,
                            Name = "MeetMe",
                            Price = 10m
                        },
                        new
                        {
                            ID = 27,
                            Name = "Netease",
                            Price = 10m
                        },
                        new
                        {
                            ID = 28,
                            Name = "Qihoo",
                            Price = 10m
                        });
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Order", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Stock", "Stock")
                        .WithMany()
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stock");
                });
#pragma warning restore 612, 618
        }
    }
}