﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PHotoFockus.Data;

namespace PHotoFockus.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20210125124604_AboutProdPage")]
    partial class AboutProdPage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("PHotoFockus.Data.models.AboutProdPage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("productid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("AboutProdPage");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.Categories", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.FockusCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FockusCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int?>("productid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("FockusCartItem");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("oderTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("surename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("orderID")
                        .HasColumnType("int");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("orderID");

                    b.HasIndex("productID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CategoriesID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("available")
                        .HasColumnType("bit");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CategoriesID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.AboutProdPage", b =>
                {
                    b.HasOne("PHotoFockus.Data.models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");

                    b.Navigation("product");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.FockusCartItem", b =>
                {
                    b.HasOne("PHotoFockus.Data.models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");

                    b.Navigation("product");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.OrderDetail", b =>
                {
                    b.HasOne("PHotoFockus.Data.models.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PHotoFockus.Data.models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.Product", b =>
                {
                    b.HasOne("PHotoFockus.Data.models.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoriesID");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PHotoFockus.Data.models.Order", b =>
                {
                    b.Navigation("orderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}