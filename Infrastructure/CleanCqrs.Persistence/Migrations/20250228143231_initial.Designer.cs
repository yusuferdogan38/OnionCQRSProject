﻿// <auto-generated />
using System;
using CleanCqrs.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanCqrs.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250228143231_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CleanCqrs.Domain.Entityies.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(4902),
                            IsDeleted = false,
                            Name = "Garden"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(4909),
                            IsDeleted = true,
                            Name = "Games"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(4948),
                            IsDeleted = false,
                            Name = "Kids & Jewelery"
                        });
                });

            modelBuilder.Entity("CleanCqrs.Domain.Entityies.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasMaxLength(150)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(6578),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(6580),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(6581),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 686, DateTimeKind.Local).AddTicks(6582),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("CleanCqrs.Domain.Entityies.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 687, DateTimeKind.Local).AddTicks(7038),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            IsDeleted = false,
                            Title = "Sıfat masaya ut quia ab patlıcan hesap aut mi ipsam."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 687, DateTimeKind.Local).AddTicks(7070),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            IsDeleted = false,
                            Title = "Odit dağılımı velit incidunt voluptas dolayı."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 687, DateTimeKind.Local).AddTicks(7094),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            IsDeleted = true,
                            Title = "Sıfat enim domates dolore sıfat ipsum."
                        });
                });

            modelBuilder.Entity("CleanCqrs.Domain.Entityies.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 688, DateTimeKind.Local).AddTicks(7032),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Discount = 88.583263934813218m,
                            IsDeleted = false,
                            Name = "Practical Metal Fish",
                            Price = 22.7781631722230416m
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 688, DateTimeKind.Local).AddTicks(7054),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Discount = 88.668658005556375m,
                            IsDeleted = false,
                            Name = "Intelligent Granite Pants",
                            Price = 94.3957668242620576m
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 3,
                            CreatedDate = new DateTime(2025, 2, 28, 17, 32, 31, 688, DateTimeKind.Local).AddTicks(7071),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Discount = 37.075960931437504m,
                            IsDeleted = false,
                            Name = "Handcrafted Granite Bacon",
                            Price = 197.273668276912672m
                        });
                });

            modelBuilder.Entity("CleanCqrs.Domain.Entityies.Detail", b =>
                {
                    b.HasOne("CleanCqrs.Domain.Entityies.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CleanCqrs.Domain.Entityies.Product", b =>
                {
                    b.HasOne("CleanCqrs.Domain.Entityies.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanCqrs.Domain.Entityies.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CleanCqrs.Domain.Entityies.Category", b =>
                {
                    b.Navigation("Details");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
