using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerService.Migrations
{
    public partial class addcustomermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerCode = table.Column<string>(nullable: true),
                    customerName = table.Column<string>(nullable: true),
                    customerAddress = table.Column<string>(nullable: true),
                    createdBy = table.Column<int>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    modifiedBy = table.Column<int>(nullable: false),
                    modifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "customerId", "createdAt", "createdBy", "customerAddress", "customerCode", "customerName", "modifiedAt", "modifiedBy" },
                values: new object[] { 1, new DateTime(2023, 8, 20, 14, 52, 53, 364, DateTimeKind.Local).AddTicks(1409), 1, "PuloGadung", "AA01", "Aaron", new DateTime(2023, 8, 20, 14, 52, 53, 365, DateTimeKind.Local).AddTicks(5735), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
