using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLTK.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    STK = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenNH = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SoDuDauKy = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.STK);
                });

            migrationBuilder.CreateTable(
                name: "GiaoDiches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoTien = table.Column<int>(type: "int", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STK = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoDiches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaoDiches_TaiKhoans_STK",
                        column: x => x.STK,
                        principalTable: "TaiKhoans",
                        principalColumn: "STK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TaiKhoans",
                columns: new[] { "STK", "SoDuDauKy", "TenNH" },
                values: new object[,]
                {
                    { "1111111746", 200m, "VCB - Ngân hàng TMCP Ngoại thương Việt Nam" },
                    { "1111111812", 100m, "VietinBank-Ngân hàng TMCP Công Thương Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "GiaoDiches",
                columns: new[] { "Id", "NoiDung", "STK", "SoTien" },
                values: new object[,]
                {
                    { 1, "Ủng hộ miền trung", "1111111746", 100 },
                    { 2, "Rút chi tiền đợt 1", "1111111746", -50 },
                    { 3, "ủng hộ miền trung", "1111111746", 120 },
                    { 4, "ủng hộ miền trung 812", "1111111812", 80 },
                    { 5, "ủng hộ miền trung tk812", "1111111812", 180 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GiaoDiches_STK",
                table: "GiaoDiches",
                column: "STK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiaoDiches");

            migrationBuilder.DropTable(
                name: "TaiKhoans");
        }
    }
}
