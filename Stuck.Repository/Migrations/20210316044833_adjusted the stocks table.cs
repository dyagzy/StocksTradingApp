using Microsoft.EntityFrameworkCore.Migrations;

namespace Stuck.Repository.Migrations
{
    public partial class adjustedthestockstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SellingPrice",
                table: "Stocks",
                type: "decimal (18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SellingPrice",
                table: "Stocks");
        }
    }
}
