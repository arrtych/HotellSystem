﻿// <auto-generated />
using System;
using HotellSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotellSystem.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20240108180256_MigrationV3")]
    partial class MigrationV3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("HotellSystem.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Budget")
                        .HasColumnType("REAL");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("HotellSystem.Models.Hotell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Hotells");
                });

            modelBuilder.Entity("HotellSystem.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("HotellId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("HotellId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HotellSystem.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BedsAmount")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HotellId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isFree")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HotellId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotellSystem.Models.Reservation", b =>
                {
                    b.HasOne("HotellSystem.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("HotellSystem.Models.Hotell", null)
                        .WithMany("Reservations")
                        .HasForeignKey("HotellId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("HotellSystem.Models.Room", b =>
                {
                    b.HasOne("HotellSystem.Models.Hotell", null)
                        .WithMany("Rooms")
                        .HasForeignKey("HotellId");

                    b.HasOne("HotellSystem.Models.Reservation", null)
                        .WithMany("Rooms")
                        .HasForeignKey("ReservationId");
                });

            modelBuilder.Entity("HotellSystem.Models.Hotell", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("HotellSystem.Models.Reservation", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}