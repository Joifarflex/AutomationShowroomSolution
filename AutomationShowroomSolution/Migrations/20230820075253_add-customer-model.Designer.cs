﻿// <auto-generated />
using System;
using CustomerService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230820075253_add-customer-model")]
    partial class addcustomermodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerService.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("createdBy")
                        .HasColumnType("int");

                    b.Property<string>("customerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("modifiedBy")
                        .HasColumnType("int");

                    b.HasKey("customerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            customerId = 1,
                            createdAt = new DateTime(2023, 8, 20, 14, 52, 53, 364, DateTimeKind.Local).AddTicks(1409),
                            createdBy = 1,
                            customerAddress = "PuloGadung",
                            customerCode = "AA01",
                            customerName = "Aaron",
                            modifiedAt = new DateTime(2023, 8, 20, 14, 52, 53, 365, DateTimeKind.Local).AddTicks(5735),
                            modifiedBy = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
