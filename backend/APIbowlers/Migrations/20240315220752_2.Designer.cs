﻿// <auto-generated />
using APIbowlers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIbowlers.Migrations
{
    [DbContext(typeof(BowlerContext))]
    [Migration("20240315220752_2")]
    partial class _2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("APIbowlers.Data.Bowlers", b =>
                {
                    b.Property<int>("BowlerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BowlerAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerMiddleInit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerZip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BowlerId");

                    b.ToTable("Bowlers");
                });
#pragma warning restore 612, 618
        }
    }
}
