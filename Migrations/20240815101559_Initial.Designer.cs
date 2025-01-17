﻿// <auto-generated />
using System;
using CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240815101559_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUD.Models.Order", b =>
                {
                    b.Property<int>("OrdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("createdAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.HasKey("OrdId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CRUD.Models.Product", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProdId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
