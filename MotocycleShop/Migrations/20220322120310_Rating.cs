using Microsoft.EntityFrameworkCore.Migrations;

namespace MotocycleShop.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Loai",
                table: "Kho",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loai",
                table: "Kho");
        }
    }
}
