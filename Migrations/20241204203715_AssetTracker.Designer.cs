﻿// <auto-generated />
using System;
using AssetTrackerEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssetTrackerEF.Migrations
{
    [DbContext(typeof(AssetTrackerContext))]
    [Migration("20241204203715_AssetTracker")]
    partial class AssetTracker
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                });

            modelBuilder.Entity("AssetTrackerEF.Phone", b =>
                {
                    b.HasBaseType("AssetTrackerEF.Asset");

                    b.HasDiscriminator().HasValue("Phone");
                });
#pragma warning restore 612, 618
        }
    }
}
