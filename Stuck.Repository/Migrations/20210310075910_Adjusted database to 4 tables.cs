using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stuck.Repository.Migrations
{
    public partial class Adjusteddatabaseto4tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrokerageAccounts_Customers_CustomerID",
                table: "BrokerageAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_BrokerageAccounts_WatchLists_WatchListId",
                table: "BrokerageAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_BrokerageAccounts_BrokerageAccountId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Securities_SecurityId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_BrokerageAccounts_BrokerageAccountId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Securities_SecurityId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityWatchList_WatchLists_WatchListsId",
                table: "SecurityWatchList");

            migrationBuilder.DropTable(
                name: "CompanyProfiles");

            migrationBuilder.DropTable(
                name: "MarketIndexes");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "Stockss");

            migrationBuilder.DropTable(
                name: "TradingInformation");

            migrationBuilder.DropTable(
                name: "Exchange");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MutualFunds",
                table: "MutualFunds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrokerageAccounts",
                table: "BrokerageAccounts");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OrderTypeId",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "WatchLists",
                newName: "WatchList");

            migrationBuilder.RenameTable(
                name: "Positions",
                newName: "Position");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "MutualFunds",
                newName: "MutualFund");

            migrationBuilder.RenameTable(
                name: "BrokerageAccounts",
                newName: "BrokerageAccount");

            migrationBuilder.RenameIndex(
                name: "IX_Positions_SecurityId",
                table: "Position",
                newName: "IX_Position_SecurityId");

            migrationBuilder.RenameIndex(
                name: "IX_Positions_BrokerageAccountId",
                table: "Position",
                newName: "IX_Position_BrokerageAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_SecurityId",
                table: "Order",
                newName: "IX_Order_SecurityId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_BrokerageAccountId",
                table: "Order",
                newName: "IX_Order_BrokerageAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_BrokerageAccounts_WatchListId",
                table: "BrokerageAccount",
                newName: "IX_BrokerageAccount_WatchListId");

            migrationBuilder.RenameIndex(
                name: "IX_BrokerageAccounts_CustomerID",
                table: "BrokerageAccount",
                newName: "IX_BrokerageAccount_CustomerID");

            migrationBuilder.AddColumn<int>(
                name: "OrderType",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchList",
                table: "WatchList",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Position",
                table: "Position",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MutualFund",
                table: "MutualFund",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrokerageAccount",
                table: "BrokerageAccount",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Balances_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Withdrawal = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    AmountDeposit = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentBalance = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    InitialBalance = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    StockSymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumbrOfShare = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayHigh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DayLow = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dividend = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Opening = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Volume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearHigh = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    _52WeeksHigh = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    _52WeeksLow = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    YearLow = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    Trades = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    AverageVolume = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    MarketCap = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    ExchangeId = table.Column<int>(type: "int", nullable: false),
                    Change = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    PercentChange = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    Lastings = table.Column<int>(type: "int", nullable: false),
                    NameOfShares = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetievalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MutualFundId = table.Column<int>(type: "int", nullable: true),
                    SecurityId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Balances_ExchangeId",
                        column: x => x.ExchangeId,
                        principalTable: "Balances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_MutualFund_MutualFundId",
                        column: x => x.MutualFundId,
                        principalTable: "MutualFund",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Securities_SecurityId",
                        column: x => x.SecurityId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Balances_CustomerId",
                table: "Balances",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_CustomerId",
                table: "Stocks",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ExchangeId",
                table: "Stocks",
                column: "ExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_MutualFundId",
                table: "Stocks",
                column: "MutualFundId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_SecurityId",
                table: "Stocks",
                column: "SecurityId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerId",
                table: "Transaction",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrokerageAccount_Customers_CustomerID",
                table: "BrokerageAccount",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BrokerageAccount_WatchList_WatchListId",
                table: "BrokerageAccount",
                column: "WatchListId",
                principalTable: "WatchList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_BrokerageAccount_BrokerageAccountId",
                table: "Order",
                column: "BrokerageAccountId",
                principalTable: "BrokerageAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Securities_SecurityId",
                table: "Order",
                column: "SecurityId",
                principalTable: "Securities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Position_BrokerageAccount_BrokerageAccountId",
                table: "Position",
                column: "BrokerageAccountId",
                principalTable: "BrokerageAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Position_Securities_SecurityId",
                table: "Position",
                column: "SecurityId",
                principalTable: "Securities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityWatchList_WatchList_WatchListsId",
                table: "SecurityWatchList",
                column: "WatchListsId",
                principalTable: "WatchList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrokerageAccount_Customers_CustomerID",
                table: "BrokerageAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_BrokerageAccount_WatchList_WatchListId",
                table: "BrokerageAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_BrokerageAccount_BrokerageAccountId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Securities_SecurityId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Position_BrokerageAccount_BrokerageAccountId",
                table: "Position");

            migrationBuilder.DropForeignKey(
                name: "FK_Position_Securities_SecurityId",
                table: "Position");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityWatchList_WatchList_WatchListsId",
                table: "SecurityWatchList");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Balances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchList",
                table: "WatchList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Position",
                table: "Position");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MutualFund",
                table: "MutualFund");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrokerageAccount",
                table: "BrokerageAccount");

            migrationBuilder.DropColumn(
                name: "OrderType",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "WatchList",
                newName: "WatchLists");

            migrationBuilder.RenameTable(
                name: "Position",
                newName: "Positions");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "MutualFund",
                newName: "MutualFunds");

            migrationBuilder.RenameTable(
                name: "BrokerageAccount",
                newName: "BrokerageAccounts");

            migrationBuilder.RenameIndex(
                name: "IX_Position_SecurityId",
                table: "Positions",
                newName: "IX_Positions_SecurityId");

            migrationBuilder.RenameIndex(
                name: "IX_Position_BrokerageAccountId",
                table: "Positions",
                newName: "IX_Positions_BrokerageAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_SecurityId",
                table: "Orders",
                newName: "IX_Orders_SecurityId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_BrokerageAccountId",
                table: "Orders",
                newName: "IX_Orders_BrokerageAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_BrokerageAccount_WatchListId",
                table: "BrokerageAccounts",
                newName: "IX_BrokerageAccounts_WatchListId");

            migrationBuilder.RenameIndex(
                name: "IX_BrokerageAccount_CustomerID",
                table: "BrokerageAccounts",
                newName: "IX_BrokerageAccounts_CustomerID");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderTypeId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MutualFunds",
                table: "MutualFunds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrokerageAccounts",
                table: "BrokerageAccounts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CompanyProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Auditor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardOfDirectors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanySecretay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateListed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfIncorporation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarketClassification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatureOfBusiness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficalClose = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfficialOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Regristra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exchange",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exchange", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarketIndexes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketIndexes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradingInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketCap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarketClassification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficalClose = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfficialOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SharesOutstanding = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubSector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TickerSymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradingInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stockss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AverageVolume = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    Change = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayHigh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DayLow = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dividend = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExchangeId = table.Column<int>(type: "int", nullable: false),
                    Lastings = table.Column<int>(type: "int", nullable: false),
                    MarketCap = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    MutualFundId = table.Column<int>(type: "int", nullable: true),
                    Opening = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercentChange = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    RetievalDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecurityId = table.Column<int>(type: "int", nullable: true),
                    Shares = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trades = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    Volume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearHigh = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    YearLow = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    _52WeeksHigh = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    _52WeeksLow = table.Column<decimal>(type: "decimal (18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stockss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stockss_Exchange_ExchangeId",
                        column: x => x.ExchangeId,
                        principalTable: "Exchange",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stockss_MutualFunds_MutualFundId",
                        column: x => x.MutualFundId,
                        principalTable: "MutualFunds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stockss_Securities_SecurityId",
                        column: x => x.SecurityId,
                        principalTable: "Securities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Stockss_ExchangeId",
                table: "Stockss",
                column: "ExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Stockss_MutualFundId",
                table: "Stockss",
                column: "MutualFundId");

            migrationBuilder.CreateIndex(
                name: "IX_Stockss_SecurityId",
                table: "Stockss",
                column: "SecurityId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrokerageAccounts_Customers_CustomerID",
                table: "BrokerageAccounts",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BrokerageAccounts_WatchLists_WatchListId",
                table: "BrokerageAccounts",
                column: "WatchListId",
                principalTable: "WatchLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_BrokerageAccounts_BrokerageAccountId",
                table: "Orders",
                column: "BrokerageAccountId",
                principalTable: "BrokerageAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Securities_SecurityId",
                table: "Orders",
                column: "SecurityId",
                principalTable: "Securities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_BrokerageAccounts_BrokerageAccountId",
                table: "Positions",
                column: "BrokerageAccountId",
                principalTable: "BrokerageAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Securities_SecurityId",
                table: "Positions",
                column: "SecurityId",
                principalTable: "Securities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityWatchList_WatchLists_WatchListsId",
                table: "SecurityWatchList",
                column: "WatchListsId",
                principalTable: "WatchLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
