using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SYS.Dal.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyID);
                });

            migrationBuilder.CreateTable(
                name: "Firm_types",
                columns: table => new
                {
                    Firm_TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firm_types", x => x.Firm_TypeID);
                });

            migrationBuilder.CreateTable(
                name: "Stock_Units",
                columns: table => new
                {
                    Stock_UnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock_Units", x => x.Stock_UnitID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Firms",
                columns: table => new
                {
                    FirmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isdelete = table.Column<bool>(type: "bit", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Firm_TypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firms", x => x.FirmID);
                    table.ForeignKey(
                        name: "FK_Firms_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Firms_Firm_types_Firm_TypeID",
                        column: x => x.Firm_TypeID,
                        principalTable: "Firm_types",
                        principalColumn: "Firm_TypeID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchasePrice = table.Column<double>(type: "float", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    VatRate = table.Column<double>(type: "float", nullable: false),
                    DiscountRate = table.Column<double>(type: "float", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Stock_UnitID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockID);
                    table.ForeignKey(
                        name: "FK_Stocks_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Stocks_Stock_Units_Stock_UnitID",
                        column: x => x.Stock_UnitID,
                        principalTable: "Stock_Units",
                        principalColumn: "Stock_UnitID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Purchaseorders",
                columns: table => new
                {
                    PurchaseOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VatRate = table.Column<double>(type: "float", nullable: false),
                    DiscountRate = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevisedDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    FirmID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    StockID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchaseorders", x => x.PurchaseOrderID);
                    table.ForeignKey(
                        name: "FK_Purchaseorders_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Purchaseorders_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Purchaseorders_Firms_FirmID",
                        column: x => x.FirmID,
                        principalTable: "Firms",
                        principalColumn: "FirmID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Purchaseorders_Stocks_StockID",
                        column: x => x.StockID,
                        principalTable: "Stocks",
                        principalColumn: "StockID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Saleorders",
                columns: table => new
                {
                    SaleOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VatRate = table.Column<double>(type: "float", nullable: false),
                    DiscountRate = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevisedDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    FirmID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    StockID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saleorders", x => x.SaleOrderID);
                    table.ForeignKey(
                        name: "FK_Saleorders_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Saleorders_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Saleorders_Firms_FirmID",
                        column: x => x.FirmID,
                        principalTable: "Firms",
                        principalColumn: "FirmID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Saleorders_Stocks_StockID",
                        column: x => x.StockID,
                        principalTable: "Stocks",
                        principalColumn: "StockID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Stock_TransferBodies",
                columns: table => new
                {
                    TansferBodyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Input = table.Column<float>(type: "real", nullable: false),
                    Output = table.Column<float>(type: "real", nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
                    DiscountRate = table.Column<float>(type: "real", nullable: false),
                    DiscountAmount = table.Column<float>(type: "real", nullable: false),
                    VatRate = table.Column<float>(type: "real", nullable: false),
                    VatAmount = table.Column<float>(type: "real", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    stock_transferheaderTransferHeaderID = table.Column<int>(type: "int", nullable: false),
                    TransferID = table.Column<int>(type: "int", nullable: false),
                    StockID = table.Column<int>(type: "int", nullable: false),
                    PurchaseOrderID = table.Column<int>(type: "int", nullable: false),
                    SaleOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock_TransferBodies", x => x.TansferBodyID);
                    table.ForeignKey(
                        name: "FK_Stock_TransferBodies_Purchaseorders_PurchaseOrderID",
                        column: x => x.PurchaseOrderID,
                        principalTable: "Purchaseorders",
                        principalColumn: "PurchaseOrderID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Stock_TransferBodies_Saleorders_SaleOrderID",
                        column: x => x.SaleOrderID,
                        principalTable: "Saleorders",
                        principalColumn: "SaleOrderID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Stock_TransferBodies_Stocks_StockID",
                        column: x => x.StockID,
                        principalTable: "Stocks",
                        principalColumn: "StockID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Stock_TransferHeaders",
                columns: table => new
                {
                    TransferHeaderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Transfer_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    FirmID = table.Column<int>(type: "int", nullable: false),
                    Stock_TransferBodyTansferBodyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock_TransferHeaders", x => x.TransferHeaderID);
                    table.ForeignKey(
                        name: "FK_Stock_TransferHeaders_Firms_FirmID",
                        column: x => x.FirmID,
                        principalTable: "Firms",
                        principalColumn: "FirmID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Stock_TransferHeaders_Stock_TransferBodies_Stock_TransferBodyTansferBodyID",
                        column: x => x.Stock_TransferBodyTansferBodyID,
                        principalTable: "Stock_TransferBodies",
                        principalColumn: "TansferBodyID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryID",
                table: "Employees",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Firms_CountryID",
                table: "Firms",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Firms_Firm_TypeID",
                table: "Firms",
                column: "Firm_TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchaseorders_CurrencyID",
                table: "Purchaseorders",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchaseorders_EmployeeID",
                table: "Purchaseorders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchaseorders_FirmID",
                table: "Purchaseorders",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchaseorders_StockID",
                table: "Purchaseorders",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_Saleorders_CurrencyID",
                table: "Saleorders",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Saleorders_EmployeeID",
                table: "Saleorders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Saleorders_FirmID",
                table: "Saleorders",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_Saleorders_StockID",
                table: "Saleorders",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_TransferBodies_PurchaseOrderID",
                table: "Stock_TransferBodies",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_TransferBodies_SaleOrderID",
                table: "Stock_TransferBodies",
                column: "SaleOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_TransferBodies_stock_transferheaderTransferHeaderID",
                table: "Stock_TransferBodies",
                column: "stock_transferheaderTransferHeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_TransferBodies_StockID",
                table: "Stock_TransferBodies",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_TransferHeaders_FirmID",
                table: "Stock_TransferHeaders",
                column: "FirmID");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_TransferHeaders_Stock_TransferBodyTansferBodyID",
                table: "Stock_TransferHeaders",
                column: "Stock_TransferBodyTansferBodyID");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_CurrencyID",
                table: "Stocks",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_Stock_UnitID",
                table: "Stocks",
                column: "Stock_UnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmployeeID",
                table: "Users",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_TransferBodies_Stock_TransferHeaders_stock_transferheaderTransferHeaderID",
                table: "Stock_TransferBodies",
                column: "stock_transferheaderTransferHeaderID",
                principalTable: "Stock_TransferHeaders",
                principalColumn: "TransferHeaderID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Countries_CountryID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Firms_Countries_CountryID",
                table: "Firms");

            migrationBuilder.DropForeignKey(
                name: "FK_Firms_Firm_types_Firm_TypeID",
                table: "Firms");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchaseorders_Currencies_CurrencyID",
                table: "Purchaseorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Saleorders_Currencies_CurrencyID",
                table: "Saleorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Currencies_CurrencyID",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchaseorders_Employees_EmployeeID",
                table: "Purchaseorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Saleorders_Employees_EmployeeID",
                table: "Saleorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchaseorders_Firms_FirmID",
                table: "Purchaseorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Saleorders_Firms_FirmID",
                table: "Saleorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_TransferHeaders_Firms_FirmID",
                table: "Stock_TransferHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchaseorders_Stocks_StockID",
                table: "Purchaseorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Saleorders_Stocks_StockID",
                table: "Saleorders");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_TransferBodies_Stocks_StockID",
                table: "Stock_TransferBodies");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_TransferBodies_Purchaseorders_PurchaseOrderID",
                table: "Stock_TransferBodies");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_TransferBodies_Saleorders_SaleOrderID",
                table: "Stock_TransferBodies");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_TransferBodies_Stock_TransferHeaders_stock_transferheaderTransferHeaderID",
                table: "Stock_TransferBodies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Firm_types");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Firms");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Stock_Units");

            migrationBuilder.DropTable(
                name: "Purchaseorders");

            migrationBuilder.DropTable(
                name: "Saleorders");

            migrationBuilder.DropTable(
                name: "Stock_TransferHeaders");

            migrationBuilder.DropTable(
                name: "Stock_TransferBodies");
        }
    }
}
