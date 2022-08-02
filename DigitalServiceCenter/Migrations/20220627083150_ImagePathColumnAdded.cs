using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalServiceCenter.Migrations
{
    public partial class ImagePathColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Companeys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Companeys");
        }
    }
}
