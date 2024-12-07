﻿// <auto-generated />
using System;
using AssetTrackerEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssetTrackerEF.Migrations
{
    [DbContext(typeof(AssetTrackerContext))]
    partial class AssetTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssetTrackerEF.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DatePurchased")
                        .HasColumnType("date");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Assets");

                    b.HasDiscriminator().HasValue("Asset");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AssetTrackerEF.Computer", b =>
                {
                    b.HasBaseType("AssetTrackerEF.Asset");

                    b.HasDiscriminator().HasValue("Computer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "HP",
                            Currency = "EUR",
                            DatePurchased = new DateOnly(2019, 6, 1),
                            Model = "Elitebook",
                            Office = "Spain",
                            Price = 1176.03m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Asus",
                            Currency = "SEK",
                            DatePurchased = new DateOnly(2020, 10, 2),
                            Model = "W234",
                            Office = "Sweden",
                            Price = 4900m
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Lenovo",
                            Currency = "USD",
                            DatePurchased = new DateOnly(2018, 5, 28),
                            Model = "Yoga 730",
                            Office = "USA",
                            Price = 835m
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Lenovo",
                            Currency = "USD",
                            DatePurchased = new DateOnly(2019, 5, 21),
                            Model = "Yoga 530",
                            Office = "USA",
                            Price = 1030m
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Apple",
                            Currency = "EUR",
                            DatePurchased = new DateOnly(2022, 7, 13),
                            Model = "Macbook Pro",
                            Office = "Spain",
                            Price = 970m
                        },
                        new
                        {
                            Id = 11,
                            Brand = "Asus",
                            Currency = "SEK",
                            DatePurchased = new DateOnly(2024, 10, 15),
                            Model = "ROG 500",
                            Office = "Sweden",
                            Price = 9999.90m
                        });
                });

            modelBuilder.Entity("AssetTrackerEF.Phone", b =>
                {
                    b.HasBaseType("AssetTrackerEF.Asset");

                    b.HasDiscriminator().HasValue("Phone");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Brand = "Apple",
                            Currency = "USD",
                            DatePurchased = new DateOnly(2024, 9, 11),
                            Model = "Iphone 15",
                            Office = "USA",
                            Price = 10000m
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Apple",
                            Currency = "EUR",
                            DatePurchased = new DateOnly(2020, 9, 25),
                            Model = "iPhone",
                            Office = "Spain",
                            Price = 818.18m
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Apple",
                            Currency = "SEK",
                            DatePurchased = new DateOnly(2018, 7, 15),
                            Model = "iPhone",
                            Office = "Sweden",
                            Price = 10375m
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Motorola",
                            Currency = "SEK",
                            DatePurchased = new DateOnly(2022, 8, 16),
                            Model = "Razr",
                            Office = "Sweden",
                            Price = 6083.33m
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Samsung",
                            Currency = "SEK",
                            DatePurchased = new DateOnly(2023, 3, 16),
                            Model = "Galaxy S23",
                            Office = "Sweden",
                            Price = 8083.33m
                        },
                        new
                        {
                            Id = 12,
                            Brand = "Nokia",
                            Currency = "EUR",
                            DatePurchased = new DateOnly(2019, 5, 16),
                            Model = "3310",
                            Office = "Germany",
                            Price = 160.11m
                        },
                        new
                        {
                            Id = 13,
                            Brand = "Xiaomi",
                            Currency = "EUR",
                            DatePurchased = new DateOnly(2023, 3, 16),
                            Model = "14 Ultra",
                            Office = "France",
                            Price = 808.08m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
