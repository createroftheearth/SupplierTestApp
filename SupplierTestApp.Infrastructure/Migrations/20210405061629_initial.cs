using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SupplierTestApp.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierNumber);
                });

            migrationBuilder.CreateTable(
                name: "SupplierRate",
                columns: table => new
                {
                    SupplierRateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierNumber = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierRate", x => x.SupplierRateId);
                    table.ForeignKey(
                        name: "FK_SupplierRate_Supplier_SupplierNumber",
                        column: x => x.SupplierNumber,
                        principalTable: "Supplier",
                        principalColumn: "SupplierNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierRate_SupplierNumber",
                table: "SupplierRate",
                column: "SupplierNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierRate");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
