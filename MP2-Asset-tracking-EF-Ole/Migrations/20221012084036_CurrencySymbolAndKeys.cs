using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MP2_Asset_tracking_EF_Ole.Migrations
{
    public partial class CurrencySymbolAndKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Currencies_CurrencyId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Officies_Countries_CountryId",
                table: "Officies");

            migrationBuilder.DropIndex(
                name: "IX_Officies_CountryId",
                table: "Officies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Officies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "CountryLetters",
                table: "Officies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Currencies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Letters",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CurrencySymbol",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "Symbol");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Letters");

            migrationBuilder.CreateIndex(
                name: "IX_Officies_CountryLetters",
                table: "Officies",
                column: "CountryLetters");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencySymbol",
                table: "Countries",
                column: "CurrencySymbol");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Currencies_CurrencySymbol",
                table: "Countries",
                column: "CurrencySymbol",
                principalTable: "Currencies",
                principalColumn: "Symbol",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Officies_Countries_CountryLetters",
                table: "Officies",
                column: "CountryLetters",
                principalTable: "Countries",
                principalColumn: "Letters",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Currencies_CurrencySymbol",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Officies_Countries_CountryLetters",
                table: "Officies");

            migrationBuilder.DropIndex(
                name: "IX_Officies_CountryLetters",
                table: "Officies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CurrencySymbol",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CountryLetters",
                table: "Officies");

            migrationBuilder.DropColumn(
                name: "Letters",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CurrencySymbol",
                table: "Countries");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Officies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Currencies",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "ExchangeFactor", "Name", "Symbol" },
                values: new object[] { 1, 1.0, "US Dollar", "USD" });

            migrationBuilder.CreateIndex(
                name: "IX_Officies_CountryId",
                table: "Officies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CurrencyId",
                table: "Countries",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Currencies_CurrencyId",
                table: "Countries",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Officies_Countries_CountryId",
                table: "Officies",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
