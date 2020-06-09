﻿// <auto-generated />
using System;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(TMDTContext))]
    [Migration("20200605010647_addQuantityInBakery")]
    partial class addQuantityInBakery
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Idcustomer")
                        .HasColumnName("IDCustomer")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("Idcustomer");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Data.Models.Bakery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Idtype")
                        .HasColumnName("IDType")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Price")
                        .HasColumnType("bigint");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Idtype");

                    b.ToTable("Bakery");
                });

            modelBuilder.Entity("Data.Models.BakeryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BakeryType");
                });

            modelBuilder.Entity("Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<int?>("Sex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("Idorder")
                        .HasColumnName("IDOrder")
                        .HasColumnType("int");

                    b.Property<int>("Idbakery")
                        .HasColumnName("IDBakery")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<long?>("Total")
                        .HasColumnType("bigint");

                    b.HasKey("Idorder", "Idbakery")
                        .HasName("orderdetail_pk");

                    b.HasIndex("Idbakery");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Data.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdBuyer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Idcustomer")
                        .HasColumnName("IDCustomer")
                        .HasColumnType("int");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Idcustomer");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Data.Models.ShoppingCart", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Data.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("IdShoppingCart")
                        .HasColumnName("IDShoppingCart")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Idbakery")
                        .HasColumnName("IDBakery")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdShoppingCart");

                    b.HasIndex("Idbakery");

                    b.ToTable("ShoppingCartItem");
                });

            modelBuilder.Entity("Data.Models.Account", b =>
                {
                    b.HasOne("Data.Models.Customer", "IdcustomerNavigation")
                        .WithMany("Account")
                        .HasForeignKey("Idcustomer")
                        .HasConstraintName("FK__Account__IDCusto__398D8EEE");
                });

            modelBuilder.Entity("Data.Models.Bakery", b =>
                {
                    b.HasOne("Data.Models.BakeryType", "IdtypeNavigation")
                        .WithMany("Bakery")
                        .HasForeignKey("Idtype")
                        .HasConstraintName("FK__Bakery__IDType__3E52440B");
                });

            modelBuilder.Entity("Data.Models.OrderDetail", b =>
                {
                    b.HasOne("Data.Models.Bakery", "IdbakeryNavigation")
                        .WithMany("OrderDetail")
                        .HasForeignKey("Idbakery")
                        .HasConstraintName("FK__OrderDeta__IDBak__44FF419A")
                        .IsRequired();

                    b.HasOne("Data.Models.Orders", "IdorderNavigation")
                        .WithMany("OrderDetail")
                        .HasForeignKey("Idorder")
                        .HasConstraintName("FK__OrderDeta__IDOrd__440B1D61")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Models.Orders", b =>
                {
                    b.HasOne("Data.Models.Customer", "IdcustomerNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("Idcustomer")
                        .HasConstraintName("FK__Orders__IDCustom__412EB0B6");
                });

            modelBuilder.Entity("Data.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Data.Models.ShoppingCart", "IdShoppingCartNavigation")
                        .WithMany("ShoppingCartItem")
                        .HasForeignKey("IdShoppingCart")
                        .HasConstraintName("FK__ShoppingCartItem__IDShoppingCart");

                    b.HasOne("Data.Models.Bakery", "IdbakeryNavigation")
                        .WithMany("ShoppingCartItem")
                        .HasForeignKey("Idbakery")
                        .HasConstraintName("FK__ShoppingCartItem__IDBak");
                });
#pragma warning restore 612, 618
        }
    }
}
