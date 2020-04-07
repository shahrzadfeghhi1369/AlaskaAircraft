﻿// <auto-generated />
using AlaskaAircraft.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlaskaAircraft.Migrations
{
    [DbContext(typeof(AlaskaAircraftContext))]
    partial class AlaskaAircraftContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlaskaAircraft.Models.Aircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(6)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EC_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LRU_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LRU_Part_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pre_Post_Condition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Software_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Software_Part_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tail_Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aircraft");
                });
#pragma warning restore 612, 618
        }
    }
}