using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MP2_Asset_tracking_EF_Ole.Migrations
{
    public partial class CurrencyAlpha2Alpha3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Officies_Countries_CountryLetters",
                table: "Officies");

            migrationBuilder.RenameColumn(
                name: "CountryLetters",
                table: "Officies",
                newName: "Alpha2");

            migrationBuilder.RenameIndex(
                name: "IX_Officies_CountryLetters",
                table: "Officies",
                newName: "IX_Officies_Alpha2");

            migrationBuilder.RenameColumn(
                name: "Letters",
                table: "Countries",
                newName: "Alpha2");

            migrationBuilder.AddColumn<string>(
                name: "Alpha3",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Officies_Countries_Alpha2",
                table: "Officies",
                column: "Alpha2",
                principalTable: "Countries",
                principalColumn: "Alpha2",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Officies_Countries_Alpha2",
                table: "Officies");

            migrationBuilder.DropColumn(
                name: "Alpha3",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "Alpha2",
                table: "Officies",
                newName: "CountryLetters");

            migrationBuilder.RenameIndex(
                name: "IX_Officies_Alpha2",
                table: "Officies",
                newName: "IX_Officies_CountryLetters");

            migrationBuilder.RenameColumn(
                name: "Alpha2",
                table: "Countries",
                newName: "Letters");

            migrationBuilder.AddForeignKey(
                name: "FK_Officies_Countries_CountryLetters",
                table: "Officies",
                column: "CountryLetters",
                principalTable: "Countries",
                principalColumn: "Letters",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
