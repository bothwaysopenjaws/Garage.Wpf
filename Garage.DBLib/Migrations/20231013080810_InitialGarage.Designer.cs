﻿// <auto-generated />
using System;
using Garage.DbLib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Garage.DbLib.Migrations
{
    [DbContext(typeof(GarageContext))]
    [Migration("20231013080810_InitialGarage")]
    partial class InitialGarage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Garage.Wpf.Models.Brand", b =>
                {
                    b.Property<int>("Identifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Identifier"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Identifier");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("Garage.Wpf.Models.Car", b =>
                {
                    b.Property<int>("Identifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Identifier"));

                    b.Property<int?>("Kilometers")
                        .HasColumnType("int");

                    b.Property<int>("ModelIdentifier")
                        .HasColumnType("int");

                    b.Property<string>("Registration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Identifier");

                    b.HasIndex("ModelIdentifier");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Garage.Wpf.Models.Model", b =>
                {
                    b.Property<int>("Identifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Identifier"));

                    b.Property<int>("BrandIdentifier")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Identifier");

                    b.HasIndex("BrandIdentifier");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("Garage.Wpf.Models.Car", b =>
                {
                    b.HasOne("Garage.Wpf.Models.Model", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("ModelIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Garage.Wpf.Models.Model", b =>
                {
                    b.HasOne("Garage.Wpf.Models.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Garage.Wpf.Models.Brand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Garage.Wpf.Models.Model", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
