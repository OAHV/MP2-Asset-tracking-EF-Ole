using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MP2_Asset_tracking_EF_Ole.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Symbol", "ExchangeFactor", "Name" },
                values: new object[,]
                {
                    { "AUD", 1.5890157359999999, "Australian dollar" },
                    { "BGN", 2.0115190780000001, "Bulgarian lev" },
                    { "BRL", 5.1893448519999996, "Brazilian real" },
                    { "CAD", 1.3783811580000001, "Canadian dollar" },
                    { "CHF", 0.99506325200000001, "Swiss franc" },
                    { "CNY", 7.1653810550000001, "Chinese yuan renminbi" },
                    { "CZK", 25.233981279999998, "Czech koruna" },
                    { "DKK", 7.6509307829999997, "Danish krone" },
                    { "EUR", 1.0284891490000001, "Euro" },
                    { "GBP", 0.90201583900000004, "Pound sterling" },
                    { "HKD", 7.849943433, "Hong Kong dollar" },
                    { "HRK", 7.7438033529999997, "Croatian kuna" },
                    { "HUF", 440.94415299999997, "Hungarian forint" },
                    { "IDR", 15356.19665, "Indonesian rupiah" },
                    { "ILS", 3.5766738660000001, "Israeli shekel" },
                    { "INR", 82.233364190000003, "Indian rupee" },
                    { "ISK", 144.70842329999999, "Icelandic krona" },
                    { "JPY", 145.57235420000001, "Japanese yen" },
                    { "KRW", 1432.5208270000001, "South Korean won" },
                    { "MXN", 19.96451712, "Mexican peso" },
                    { "MYR", 4.6730432989999997, "Malaysian ringgit" },
                    { "NOK", 10.720456649999999, "Norwegian krone" },
                    { "NZD", 1.7816517540000001, "New Zealand dollar" },
                    { "PHP", 58.873804380000003, "Philippine peso" },
                    { "PLN", 5.0077136690000001, "Polish zloty" },
                    { "RON", 5.0801193050000002, "Romanian leu" },
                    { "SEK", 11.31492338, "Swedish krona" },
                    { "SGD", 1.4364907950000001, "Singapore dollar" },
                    { "THB", 38.084953200000001, "Thai baht" },
                    { "TRY", 18.583359049999999, "Turkish lira" },
                    { "USD", 1.0, "US dollar" },
                    { "ZAR", 18.11714491, "South African rand" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Alpha2", "Alpha3", "CurrencySymbol", "Name", "Numeric" },
                values: new object[,]
                {
                    { "AD", "AND", "EUR", "Andorra", 20 },
                    { "AT", "AUT", "EUR", "Austria", 40 },
                    { "AU", "AUS", "AUD", "Australia", 36 },
                    { "AX", "ALA", "EUR", "Åland Islands", 248 },
                    { "BE", "BEL", "EUR", "Belgium", 56 },
                    { "BG", "BGR", "BGN", "Bulgaria", 100 },
                    { "BR", "BRA", "BRL", "Brazil", 76 },
                    { "CA", "CAN", "CAD", "Canada", 124 },
                    { "CH", "CHE", "CHF", "Switzerland", 756 },
                    { "CN", "CHN", "CNY", "China", 156 },
                    { "CY", "CYP", "EUR", "Cyprus", 196 },
                    { "CZ", "CZE", "CZK", "Czech Republic", 203 },
                    { "DE", "DEU", "EUR", "Germany", 276 },
                    { "DK", "DNK", "DKK", "Denmark", 208 },
                    { "EC", "ECU", "USD", "Ecuador", 218 },
                    { "EE", "EST", "EUR", "Estonia", 233 },
                    { "ES", "ESP", "EUR", "Spain", 724 },
                    { "FI", "FIN", "EUR", "Finland", 246 },
                    { "FM", "FSM", "USD", "Micronesia", 583 },
                    { "FO", "FRO", "DKK", "Faroe Islands", 234 },
                    { "FR", "FRA", "EUR", "France", 250 },
                    { "GB", "GBR", "GBP", "United Kingdom", 826 },
                    { "GI", "GIB", "GBP", "Gibraltar", 292 },
                    { "GL", "GRL", "DKK", "Greenland", 304 },
                    { "GR", "GRC", "EUR", "Greece", 300 },
                    { "HK", "HKG", "CNY", "Hong Kong", 344 },
                    { "HR", "HRV", "HRK", "Croatia", 191 },
                    { "HU", "HUN", "HUF", "Hungary", 348 },
                    { "ID", "IDN", "IDR", "Indonesia", 360 },
                    { "IE", "IRL", "EUR", "Ireland", 372 },
                    { "IL", "ISR", "ILS", "Israel", 376 },
                    { "IM", "IMN", "GBP", "Isle of Man", 833 },
                    { "IN", "IND", "INR", "India", 356 },
                    { "IS", "ISL", "ISK", "Iceland", 352 },
                    { "IT", "ITA", "EUR", "Italy", 380 },
                    { "JE", "JEY", "GBP", "Jersey", 832 },
                    { "JP", "JPN", "JPY", "Japan", 392 },
                    { "KI", "KIR", "AUD", "Kiribati", 296 },
                    { "KR", "KOR", "KRW", "Republic of Korea", 410 },
                    { "LI", "LIE", "CHF", "Liechtenstein", 438 },
                    { "LT", "LTU", "EUR", "Lithuania", 440 },
                    { "LU", "LUX", "EUR", "Luxembourg", 442 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Alpha2", "Alpha3", "CurrencySymbol", "Name", "Numeric" },
                values: new object[,]
                {
                    { "LV", "LVA", "EUR", "Latvia", 428 },
                    { "MC", "MCO", "EUR", "Monaco", 492 },
                    { "ME", "MNE", "EUR", "Montenegro", 499 },
                    { "MH", "MHL", "USD", "Marshall Islands", 584 },
                    { "MO", "MAC", "CNY", "Macao", 446 },
                    { "MT", "MLT", "EUR", "Malta", 470 },
                    { "MX", "MEX", "MXN", "Mexico", 484 },
                    { "MY", "MYS", "MYR", "Malaysia", 458 },
                    { "NF", "NFK", "GBP", "Norfolk Island", 574 },
                    { "NL", "NLD", "EUR", "Netherlands", 528 },
                    { "NO", "NOR", "NOK", "Norway", 578 },
                    { "NR", "NRU", "AUD", "Nauru", 520 },
                    { "NZ", "NZL", "NZD", "New Zealand", 554 },
                    { "PH", "PHL", "PHP", "Philippines", 608 },
                    { "PL", "POL", "PLN", "Poland", 616 },
                    { "PS", "PSE", "ILS", "Palestine", 275 },
                    { "PT", "PRT", "EUR", "Portugal", 620 },
                    { "PW", "PLW", "USD", "Palau", 585 },
                    { "RO", "ROU", "RON", "Romania", 642 },
                    { "SE", "SWE", "SEK", "Sweden", 752 },
                    { "SG", "SGP", "SGD", "Singapore", 702 },
                    { "SI", "SVN", "EUR", "Slovenia", 705 },
                    { "SJ", "SJM", "DKK", "Svalbard and Jan Mayen", 744 },
                    { "SK", "SVK", "EUR", "Slovakia", 703 },
                    { "SM", "SMR", "EUR", "San Marino", 674 },
                    { "SV", "SLV", "USD", "El Salvador", 222 },
                    { "TH", "THA", "THB", "Thailand", 764 },
                    { "TL", "TLS", "USD", "Timor-Leste", 626 },
                    { "TR", "TUR", "TRY", "Turkey", 792 },
                    { "TV", "TUV", "AUD", "Tuvalu", 798 },
                    { "US", "USA", "USD", "United States of America", 840 },
                    { "ZA", "ZAF", "ZAR", "South Africa", 710 },
                    { "ZW", "ZWE", "USD", "Zimbabwe", 716 }
                });

            migrationBuilder.InsertData(
                table: "Officies",
                columns: new[] { "Id", "Alpha2", "Name" },
                values: new object[,]
                {
                    { 1, "SE", "Malmö" },
                    { 2, "SE", "Göteborg" },
                    { 3, "SE", "Stockholm" },
                    { 4, "DK", "Copenhagen" },
                    { 5, "DK", "Århus" },
                    { 6, "DK", "Odense" },
                    { 7, "FI", "Helsinki" },
                    { 8, "NO", "Oslo" },
                    { 9, "US", "New York" },
                    { 10, "FR", "Paris" },
                    { 11, "ES", "Madrid" },
                    { 12, "IT", "Rome" },
                    { 13, "GB", "London" },
                    { 14, "SE", "Lund" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "AD");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "AT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "AU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "AX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "BG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "BR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "CA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "CH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "CN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "CY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "CZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "EC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "EE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "FM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "FO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "GI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "GL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "GR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "HK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "HR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "HU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "ID");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "IE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "IL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "IM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "IN");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "IS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "JE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "JP");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "KI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "KR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "LI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "LT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "LU");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "LV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "MC");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "ME");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "MH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "MO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "MT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "MX");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "MY");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "NF");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "NL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "NR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "NZ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "PH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "PL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "PS");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "PT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "PW");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "RO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "SG");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "SI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "SJ");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "SK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "SM");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "SV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "TH");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "TL");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "TR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "TV");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "ZA");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "ZW");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "HKD");

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Officies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "DK");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "ES");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "FI");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "GB");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "IT");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "NO");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "SE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Alpha2",
                keyValue: "US");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "AUD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "BGN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "BRL");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "CAD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "CHF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "CNY");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "CZK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "HRK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "HUF");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "IDR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "ILS");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "INR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "ISK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "JPY");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "KRW");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "MXN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "MYR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "NZD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "PHP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "PLN");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "RON");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "SGD");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "THB");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "TRY");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "ZAR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "DKK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "EUR");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "GBP");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "NOK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "SEK");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Symbol",
                keyValue: "USD");
        }
    }
}
