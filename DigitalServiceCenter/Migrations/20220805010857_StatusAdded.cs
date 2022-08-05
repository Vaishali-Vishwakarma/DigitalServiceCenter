using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalServiceCenter.Migrations
{
    public partial class StatusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<string>(
                name: "CompaneyName",
                table: "Companeys",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Companeys",
                type: "bit",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Companeys");

            migrationBuilder.AlterColumn<string>(
                name: "CompaneyName",
                table: "Companeys",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);
        }
    }
}
