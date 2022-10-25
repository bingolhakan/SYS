﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SYS.Dal.Conctrete.EntityFramework;

#nullable disable

namespace SYS.Dal.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SYS.Entities.Concrete.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryID"), 1L, 1);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Currency", b =>
                {
                    b.Property<int>("CurrencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CurrencyID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasKey("CurrencyID");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("CountryID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Firm", b =>
                {
                    b.Property<int>("FirmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FirmID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Firm_TypeID")
                        .HasColumnType("int");

                    b.Property<bool>("Isdelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxOffice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FirmID");

                    b.HasIndex("CountryID");

                    b.HasIndex("Firm_TypeID");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Firm_Type", b =>
                {
                    b.Property<int>("Firm_TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Firm_TypeID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.HasKey("Firm_TypeID");

                    b.ToTable("Firm_types");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.PurchaseOrder", b =>
                {
                    b.Property<int>("PurchaseOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseOrderID"), 1L, 1);

                    b.Property<int>("CurrencyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("DiscountRate")
                        .HasColumnType("float");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("FirmID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<DateTime>("RevisedDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<double>("VatRate")
                        .HasColumnType("float");

                    b.HasKey("PurchaseOrderID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("FirmID");

                    b.HasIndex("StockID");

                    b.ToTable("Purchaseorders");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.SaleOrder", b =>
                {
                    b.Property<int>("SaleOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleOrderID"), 1L, 1);

                    b.Property<int>("CurrencyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("DiscountRate")
                        .HasColumnType("float");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("FirmID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<DateTime>("RevisedDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<double>("VatRate")
                        .HasColumnType("float");

                    b.HasKey("SaleOrderID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("FirmID");

                    b.HasIndex("StockID");

                    b.ToTable("Saleorders");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockID"), 1L, 1);

                    b.Property<int>("CurrencyID")
                        .HasColumnType("int");

                    b.Property<double>("DiscountRate")
                        .HasColumnType("float");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<int>("Stock_UnitID")
                        .HasColumnType("int");

                    b.Property<double>("VatRate")
                        .HasColumnType("float");

                    b.HasKey("StockID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("Stock_UnitID");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock_TransferBody", b =>
                {
                    b.Property<int>("TransferBodyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransferBodyID"), 1L, 1);

                    b.Property<float>("DiscountAmount")
                        .HasColumnType("real");

                    b.Property<float>("DiscountRate")
                        .HasColumnType("real");

                    b.Property<float>("Input")
                        .HasColumnType("real");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<float>("Output")
                        .HasColumnType("real");

                    b.Property<int>("PurchaseOrderID")
                        .HasColumnType("int");

                    b.Property<int>("SaleOrderID")
                        .HasColumnType("int");

                    b.Property<int>("StockID")
                        .HasColumnType("int");

                    b.Property<int>("TransferHeaderID")
                        .HasColumnType("int");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.Property<float>("VatAmount")
                        .HasColumnType("real");

                    b.Property<float>("VatRate")
                        .HasColumnType("real");

                    b.Property<int>("stock_transferheaderTransferHeaderID")
                        .HasColumnType("int");

                    b.HasKey("TransferBodyID");

                    b.HasIndex("PurchaseOrderID");

                    b.HasIndex("SaleOrderID");

                    b.HasIndex("StockID");

                    b.HasIndex("stock_transferheaderTransferHeaderID");

                    b.ToTable("Stock_TransferBodies");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock_TransferHeader", b =>
                {
                    b.Property<int>("TransferHeaderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransferHeaderID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FirmID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int?>("Stock_TransferBodyTransferBodyID")
                        .HasColumnType("int");

                    b.Property<string>("Transfer_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransferHeaderID");

                    b.HasIndex("FirmID");

                    b.HasIndex("Stock_TransferBodyTransferBodyID");

                    b.ToTable("Stock_TransferHeaders");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock_Unit", b =>
                {
                    b.Property<int>("Stock_UnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Stock_UnitID"), 1L, 1);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("UnitDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Stock_UnitID");

                    b.ToTable("Stock_Units");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Employee", b =>
                {
                    b.HasOne("SYS.Entities.Concrete.Country", "country")
                        .WithMany("Employee")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Firm", b =>
                {
                    b.HasOne("SYS.Entities.Concrete.Country", "country")
                        .WithMany("Firm")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Firm_Type", "firm_type")
                        .WithMany("Firms")
                        .HasForeignKey("Firm_TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");

                    b.Navigation("firm_type");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.PurchaseOrder", b =>
                {
                    b.HasOne("SYS.Entities.Concrete.Currency", "currency")
                        .WithMany("Purchaseorders")
                        .HasForeignKey("CurrencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Employee", "employee")
                        .WithMany("Purchaseorders")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Firm", "firm")
                        .WithMany("Purchaseorders")
                        .HasForeignKey("FirmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Stock", "stock")
                        .WithMany("Purchaseorders")
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("currency");

                    b.Navigation("employee");

                    b.Navigation("firm");

                    b.Navigation("stock");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.SaleOrder", b =>
                {
                    b.HasOne("SYS.Entities.Concrete.Currency", "currency")
                        .WithMany("Salesorders")
                        .HasForeignKey("CurrencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Employee", "employee")
                        .WithMany("Saleorders")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Firm", "firm")
                        .WithMany("Saleorders")
                        .HasForeignKey("FirmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Stock", "stock")
                        .WithMany("Saleorders")
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("currency");

                    b.Navigation("employee");

                    b.Navigation("firm");

                    b.Navigation("stock");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock", b =>
                {
                    b.HasOne("SYS.Entities.Concrete.Currency", "currency")
                        .WithMany("Stocks")
                        .HasForeignKey("CurrencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Stock_Unit", "stock_unit")
                        .WithMany("Stocks")
                        .HasForeignKey("Stock_UnitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("currency");

                    b.Navigation("stock_unit");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock_TransferBody", b =>
                {
                    b.HasOne("SYS.Entities.Concrete.PurchaseOrder", "purchaseorder")
                        .WithMany("Stock_TransferBodys")
                        .HasForeignKey("PurchaseOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.SaleOrder", "saleorder")
                        .WithMany("Stock_TransferBodys")
                        .HasForeignKey("SaleOrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Stock", "stock")
                        .WithMany("Stock_TransferBodies")
                        .HasForeignKey("StockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Stock_TransferHeader", "stock_transferheader")
                        .WithMany()
                        .HasForeignKey("stock_transferheaderTransferHeaderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("purchaseorder");

                    b.Navigation("saleorder");

                    b.Navigation("stock");

                    b.Navigation("stock_transferheader");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock_TransferHeader", b =>
                {
                    b.HasOne("SYS.Entities.Concrete.Firm", "firms")
                        .WithMany("Stock_TransferHeaders")
                        .HasForeignKey("FirmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SYS.Entities.Concrete.Stock_TransferBody", null)
                        .WithMany("stock_transferheaders")
                        .HasForeignKey("Stock_TransferBodyTransferBodyID");

                    b.Navigation("firms");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Users", b =>
                {
                    b.HasOne("SYS.Entities.Concrete.Employee", "employee")
                        .WithMany("Users")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Country", b =>
                {
                    b.Navigation("Employee");

                    b.Navigation("Firm");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Currency", b =>
                {
                    b.Navigation("Purchaseorders");

                    b.Navigation("Salesorders");

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Employee", b =>
                {
                    b.Navigation("Purchaseorders");

                    b.Navigation("Saleorders");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Firm", b =>
                {
                    b.Navigation("Purchaseorders");

                    b.Navigation("Saleorders");

                    b.Navigation("Stock_TransferHeaders");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Firm_Type", b =>
                {
                    b.Navigation("Firms");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.PurchaseOrder", b =>
                {
                    b.Navigation("Stock_TransferBodys");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.SaleOrder", b =>
                {
                    b.Navigation("Stock_TransferBodys");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock", b =>
                {
                    b.Navigation("Purchaseorders");

                    b.Navigation("Saleorders");

                    b.Navigation("Stock_TransferBodies");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock_TransferBody", b =>
                {
                    b.Navigation("stock_transferheaders");
                });

            modelBuilder.Entity("SYS.Entities.Concrete.Stock_Unit", b =>
                {
                    b.Navigation("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
