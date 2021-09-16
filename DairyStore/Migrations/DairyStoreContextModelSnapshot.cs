﻿// <auto-generated />
using System;
using DairyStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DairyStore.Migrations
{
    [DbContext(typeof(DairyStoreContext))]
    partial class DairyStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DairyStore.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ditem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Qtype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("productid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DairyStore.Models.Owner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("DairyStore.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ditem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Qtype")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DairyStore.Models.Suppliers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ditem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Qtype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("productid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("DairyStore.Models.Order", b =>
                {
                    b.HasOne("DairyStore.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");

                    b.Navigation("product");
                });

            modelBuilder.Entity("DairyStore.Models.Suppliers", b =>
                {
                    b.HasOne("DairyStore.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");

                    b.Navigation("product");
                });
#pragma warning restore 612, 618
        }
    }
}