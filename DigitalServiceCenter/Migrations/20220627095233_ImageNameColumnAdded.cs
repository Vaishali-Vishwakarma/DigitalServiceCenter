using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalServiceCenter.Migrations
{
    public partial class ImageNameColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Companeys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Companeys");
        }
    }
}
