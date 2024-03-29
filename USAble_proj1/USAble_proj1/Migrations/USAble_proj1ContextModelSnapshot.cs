﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using USAble_proj1.Data;

#nullable disable

namespace USAble_proj1.Migrations
{
    [DbContext(typeof(USAble_proj1Context))]
    partial class USAble_proj1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("USAble_proj1.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Closed")
                        .HasColumnType("bit");

                    b.Property<string>("Discount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Subtotal")
                        .HasColumnType("float");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
