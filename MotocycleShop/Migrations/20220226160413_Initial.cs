using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotocycleShop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    NgayNhap = table.Column<DateTime>(nullable: false),
                    PhanKhuc = table.Column<string>(nullable: true),
                    Gia = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kho", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kho");
        }
    }
}
