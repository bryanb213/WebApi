﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetApi.Data;

namespace NetApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200612185421_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NetApi.Models.Command", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("HowTo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Line")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Platform")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Commands");
                });
#pragma warning restore 612, 618
        }
    }
}