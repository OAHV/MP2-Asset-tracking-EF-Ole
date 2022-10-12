using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MP2_Asset_tracking_EF_Ole.Migrations
{
    public partial class CountryNumeric : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Numeric",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numeric",
                table: "Countries");
        }
    }
}
