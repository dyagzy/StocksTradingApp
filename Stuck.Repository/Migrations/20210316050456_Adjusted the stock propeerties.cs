using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stuck.Repository.Migrations
{
    public partial class Adjustedthestockpropeerties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Balances_ExchangeId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_ExchangeId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Change",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "DayHigh",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "DayLow",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "ExchangeId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Lastings",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "PercentChange",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "RetievalDateTime",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "YearHigh",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "_52WeeksHigh",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "_52WeeksLow",
                table: "Stocks");

            migrationBuilder.AddColumn<int>(
                name: "BalancesId",
                table: "Stocks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_BalancesId",
                table: "Stocks",
                column: "BalancesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Balances_BalancesId",
                table: "Stocks",
                column: "BalancesId",
                principalTable: "Balances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Balances_BalancesId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_BalancesId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "BalancesId",
                table: "Stocks");

            migrationBuilder.AddColumn<decimal>(
                name: "Change",
                table: "Stocks",
                type: "decimal (18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DayHigh",
                table: "Stocks",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DayLow",
                table: "Stocks",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ExchangeId",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Lastings",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PercentChange",
                table: "Stocks",
                type: "decimal (18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "RetievalDateTime",
                table: "Stocks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Volume",
                table: "Stocks",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "YearHigh",
                table: "Stocks",
                type: "decimal (18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "_52WeeksHigh",
                table: "Stocks",
                type: "decimal (18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "_52WeeksLow",
                table: "Stocks",
                type: "decimal (18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ExchangeId",
                table: "Stocks",
                column: "ExchangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Balances_ExchangeId",
                table: "Stocks",
                column: "ExchangeId",
                principalTable: "Balances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
