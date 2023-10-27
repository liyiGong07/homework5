﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcCart.Data;

#nullable disable

namespace MvcCart.Migrations
{
    [DbContext(typeof(MvcCartContext))]
    partial class MvcCartContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MvcCart.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("cart_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("createtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<string>("product_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("product_num")
                        .HasColumnType("int");

                    b.Property<double>("product_price")
                        .HasColumnType("float");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });
#pragma warning restore 612, 618
        }
    }
}
