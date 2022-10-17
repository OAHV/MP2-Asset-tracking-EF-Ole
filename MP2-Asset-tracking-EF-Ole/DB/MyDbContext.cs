using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using MP2_Asset_tracking_EF_Ole.Models;
using Microsoft.EntityFrameworkCore.Design;



namespace MP2_Asset_tracking_EF_Ole.DB
{
    internal class AssetsDB : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Office> Officies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        string connectionString = "Data Source=OLE-LAPTOP;Initial Catalog=AssetTracking;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Data seeding
        // The seeding doesn't always work for me and I have been unable to figure out why.
        // If it doesn't work for you, please use the 'assettracking.bak' backup file provided in the depository
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Currencies
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Australian dollar", Symbol = "AUD", ExchangeFactor = 1.589015736 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Bulgarian lev", Symbol = "BGN", ExchangeFactor = 2.011519078 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Brazilian real", Symbol = "BRL", ExchangeFactor = 5.189344852 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Canadian dollar", Symbol = "CAD", ExchangeFactor = 1.378381158 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Swiss franc", Symbol = "CHF", ExchangeFactor = 0.995063252 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Chinese yuan renminbi", Symbol = "CNY", ExchangeFactor = 7.165381055 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Czech koruna", Symbol = "CZK", ExchangeFactor = 25.23398128 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Danish krone", Symbol = "DKK", ExchangeFactor = 7.650930783 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Euro", Symbol = "EUR", ExchangeFactor = 1.028489149 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Pound sterling", Symbol = "GBP", ExchangeFactor = 0.902015839 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Hong Kong dollar", Symbol = "HKD", ExchangeFactor = 7.849943433 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Croatian kuna", Symbol = "HRK", ExchangeFactor = 7.743803353 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Hungarian forint", Symbol = "HUF", ExchangeFactor = 440.944153 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Indonesian rupiah", Symbol = "IDR", ExchangeFactor = 15356.19665 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Israeli shekel", Symbol = "ILS", ExchangeFactor = 3.576673866 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Indian rupee", Symbol = "INR", ExchangeFactor = 82.23336419 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Icelandic krona", Symbol = "ISK", ExchangeFactor = 144.7084233 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Japanese yen", Symbol = "JPY", ExchangeFactor = 145.5723542 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "South Korean won", Symbol = "KRW", ExchangeFactor = 1432.520827 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Mexican peso", Symbol = "MXN", ExchangeFactor = 19.96451712 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Malaysian ringgit", Symbol = "MYR", ExchangeFactor = 4.673043299 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Norwegian krone", Symbol = "NOK", ExchangeFactor = 10.72045665 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "New Zealand dollar", Symbol = "NZD", ExchangeFactor = 1.781651754 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Philippine peso", Symbol = "PHP", ExchangeFactor = 58.87380438 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Polish zloty", Symbol = "PLN", ExchangeFactor = 5.007713669 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Romanian leu", Symbol = "RON", ExchangeFactor = 5.080119305 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Swedish krona", Symbol = "SEK", ExchangeFactor = 11.31492338 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Singapore dollar", Symbol = "SGD", ExchangeFactor = 1.436490795 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Thai baht", Symbol = "THB", ExchangeFactor = 38.0849532 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "Turkish lira", Symbol = "TRY", ExchangeFactor = 18.58335905 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "US dollar", Symbol = "USD", ExchangeFactor = 1 });
            modelBuilder.Entity<Currency>().HasData(new Currency { Name = "South African rand", Symbol = "ZAR", ExchangeFactor = 18.11714491 });

            // Countries
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Andorra", CurrencySymbol = "EUR", Alpha2 = "AD", Alpha3 = "AND", Numeric = 20 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Austria", CurrencySymbol = "EUR", Alpha2 = "AT", Alpha3 = "AUT", Numeric = 40 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Australia", CurrencySymbol = "AUD", Alpha2 = "AU", Alpha3 = "AUS", Numeric = 36 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Åland Islands", CurrencySymbol = "EUR", Alpha2 = "AX", Alpha3 = "ALA", Numeric = 248 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Belgium", CurrencySymbol = "EUR", Alpha2 = "BE", Alpha3 = "BEL", Numeric = 56 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Bulgaria", CurrencySymbol = "BGN", Alpha2 = "BG", Alpha3 = "BGR", Numeric = 100 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Brazil", CurrencySymbol = "BRL", Alpha2 = "BR", Alpha3 = "BRA", Numeric = 76 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Canada", CurrencySymbol = "CAD", Alpha2 = "CA", Alpha3 = "CAN", Numeric = 124 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Switzerland", CurrencySymbol = "CHF", Alpha2 = "CH", Alpha3 = "CHE", Numeric = 756 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "China", CurrencySymbol = "CNY", Alpha2 = "CN", Alpha3 = "CHN", Numeric = 156 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Cyprus", CurrencySymbol = "EUR", Alpha2 = "CY", Alpha3 = "CYP", Numeric = 196 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Czech Republic", CurrencySymbol = "CZK", Alpha2 = "CZ", Alpha3 = "CZE", Numeric = 203 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Germany", CurrencySymbol = "EUR", Alpha2 = "DE", Alpha3 = "DEU", Numeric = 276 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Denmark", CurrencySymbol = "DKK", Alpha2 = "DK", Alpha3 = "DNK", Numeric = 208 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Ecuador", CurrencySymbol = "USD", Alpha2 = "EC", Alpha3 = "ECU", Numeric = 218 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Estonia", CurrencySymbol = "EUR", Alpha2 = "EE", Alpha3 = "EST", Numeric = 233 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Spain", CurrencySymbol = "EUR", Alpha2 = "ES", Alpha3 = "ESP", Numeric = 724 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Finland", CurrencySymbol = "EUR", Alpha2 = "FI", Alpha3 = "FIN", Numeric = 246 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Micronesia", CurrencySymbol = "USD", Alpha2 = "FM", Alpha3 = "FSM", Numeric = 583 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Faroe Islands", CurrencySymbol = "DKK", Alpha2 = "FO", Alpha3 = "FRO", Numeric = 234 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "France", CurrencySymbol = "EUR", Alpha2 = "FR", Alpha3 = "FRA", Numeric = 250 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "United Kingdom", CurrencySymbol = "GBP", Alpha2 = "GB", Alpha3 = "GBR", Numeric = 826 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Gibraltar", CurrencySymbol = "GBP", Alpha2 = "GI", Alpha3 = "GIB", Numeric = 292 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Greenland", CurrencySymbol = "DKK", Alpha2 = "GL", Alpha3 = "GRL", Numeric = 304 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Greece", CurrencySymbol = "EUR", Alpha2 = "GR", Alpha3 = "GRC", Numeric = 300 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Hong Kong", CurrencySymbol = "CNY", Alpha2 = "HK", Alpha3 = "HKG", Numeric = 344 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Croatia", CurrencySymbol = "HRK", Alpha2 = "HR", Alpha3 = "HRV", Numeric = 191 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Hungary", CurrencySymbol = "HUF", Alpha2 = "HU", Alpha3 = "HUN", Numeric = 348 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Indonesia", CurrencySymbol = "IDR", Alpha2 = "ID", Alpha3 = "IDN", Numeric = 360 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Ireland", CurrencySymbol = "EUR", Alpha2 = "IE", Alpha3 = "IRL", Numeric = 372 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Israel", CurrencySymbol = "ILS", Alpha2 = "IL", Alpha3 = "ISR", Numeric = 376 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Isle of Man", CurrencySymbol = "GBP", Alpha2 = "IM", Alpha3 = "IMN", Numeric = 833 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "India", CurrencySymbol = "INR", Alpha2 = "IN", Alpha3 = "IND", Numeric = 356 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Iceland", CurrencySymbol = "ISK", Alpha2 = "IS", Alpha3 = "ISL", Numeric = 352 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Italy", CurrencySymbol = "EUR", Alpha2 = "IT", Alpha3 = "ITA", Numeric = 380 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Jersey", CurrencySymbol = "GBP", Alpha2 = "JE", Alpha3 = "JEY", Numeric = 832 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Japan", CurrencySymbol = "JPY", Alpha2 = "JP", Alpha3 = "JPN", Numeric = 392 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Kiribati", CurrencySymbol = "AUD", Alpha2 = "KI", Alpha3 = "KIR", Numeric = 296 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Republic of Korea", CurrencySymbol = "KRW", Alpha2 = "KR", Alpha3 = "KOR", Numeric = 410 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Liechtenstein", CurrencySymbol = "CHF", Alpha2 = "LI", Alpha3 = "LIE", Numeric = 438 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Lithuania", CurrencySymbol = "EUR", Alpha2 = "LT", Alpha3 = "LTU", Numeric = 440 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Luxembourg", CurrencySymbol = "EUR", Alpha2 = "LU", Alpha3 = "LUX", Numeric = 442 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Latvia", CurrencySymbol = "EUR", Alpha2 = "LV", Alpha3 = "LVA", Numeric = 428 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Monaco", CurrencySymbol = "EUR", Alpha2 = "MC", Alpha3 = "MCO", Numeric = 492 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Montenegro", CurrencySymbol = "EUR", Alpha2 = "ME", Alpha3 = "MNE", Numeric = 499 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Marshall Islands", CurrencySymbol = "USD", Alpha2 = "MH", Alpha3 = "MHL", Numeric = 584 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Macao", CurrencySymbol = "CNY", Alpha2 = "MO", Alpha3 = "MAC", Numeric = 446 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Malta", CurrencySymbol = "EUR", Alpha2 = "MT", Alpha3 = "MLT", Numeric = 470 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Mexico", CurrencySymbol = "MXN", Alpha2 = "MX", Alpha3 = "MEX", Numeric = 484 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Malaysia", CurrencySymbol = "MYR", Alpha2 = "MY", Alpha3 = "MYS", Numeric = 458 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Norfolk Island", CurrencySymbol = "GBP", Alpha2 = "NF", Alpha3 = "NFK", Numeric = 574 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Netherlands", CurrencySymbol = "EUR", Alpha2 = "NL", Alpha3 = "NLD", Numeric = 528 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Norway", CurrencySymbol = "NOK", Alpha2 = "NO", Alpha3 = "NOR", Numeric = 578 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Nauru", CurrencySymbol = "AUD", Alpha2 = "NR", Alpha3 = "NRU", Numeric = 520 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "New Zealand", CurrencySymbol = "NZD", Alpha2 = "NZ", Alpha3 = "NZL", Numeric = 554 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Philippines", CurrencySymbol = "PHP", Alpha2 = "PH", Alpha3 = "PHL", Numeric = 608 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Poland", CurrencySymbol = "PLN", Alpha2 = "PL", Alpha3 = "POL", Numeric = 616 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Palestine", CurrencySymbol = "ILS", Alpha2 = "PS", Alpha3 = "PSE", Numeric = 275 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Portugal", CurrencySymbol = "EUR", Alpha2 = "PT", Alpha3 = "PRT", Numeric = 620 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Palau", CurrencySymbol = "USD", Alpha2 = "PW", Alpha3 = "PLW", Numeric = 585 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Romania", CurrencySymbol = "RON", Alpha2 = "RO", Alpha3 = "ROU", Numeric = 642 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Sweden", CurrencySymbol = "SEK", Alpha2 = "SE", Alpha3 = "SWE", Numeric = 752 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Singapore", CurrencySymbol = "SGD", Alpha2 = "SG", Alpha3 = "SGP", Numeric = 702 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Slovenia", CurrencySymbol = "EUR", Alpha2 = "SI", Alpha3 = "SVN", Numeric = 705 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Svalbard and Jan Mayen", CurrencySymbol = "DKK", Alpha2 = "SJ", Alpha3 = "SJM", Numeric = 744 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Slovakia", CurrencySymbol = "EUR", Alpha2 = "SK", Alpha3 = "SVK", Numeric = 703 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "San Marino", CurrencySymbol = "EUR", Alpha2 = "SM", Alpha3 = "SMR", Numeric = 674 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "El Salvador", CurrencySymbol = "USD", Alpha2 = "SV", Alpha3 = "SLV", Numeric = 222 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Thailand", CurrencySymbol = "THB", Alpha2 = "TH", Alpha3 = "THA", Numeric = 764 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Timor-Leste", CurrencySymbol = "USD", Alpha2 = "TL", Alpha3 = "TLS", Numeric = 626 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Turkey", CurrencySymbol = "TRY", Alpha2 = "TR", Alpha3 = "TUR", Numeric = 792 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Tuvalu", CurrencySymbol = "AUD", Alpha2 = "TV", Alpha3 = "TUV", Numeric = 798 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "United States of America", CurrencySymbol = "USD", Alpha2 = "US", Alpha3 = "USA", Numeric = 840 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "South Africa", CurrencySymbol = "ZAR", Alpha2 = "ZA", Alpha3 = "ZAF", Numeric = 710 });
            modelBuilder.Entity<Country>().HasData(new Country { Name = "Zimbabwe", CurrencySymbol = "USD", Alpha2 = "ZW", Alpha3 = "ZWE", Numeric = 716 });

            // Officies
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Malmö", Alpha2 = "SE", Id = 1 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Göteborg", Alpha2 = "SE", Id = 2 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Stockholm", Alpha2 = "SE", Id = 3 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Copenhagen", Alpha2 = "DK", Id = 4 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Århus", Alpha2 = "DK", Id = 5 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Odense", Alpha2 = "DK", Id = 6 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Helsinki", Alpha2 = "FI", Id = 7 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Oslo", Alpha2 = "NO", Id = 8 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "New York", Alpha2 = "US", Id = 9 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Paris", Alpha2 = "FR", Id = 10 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Madrid", Alpha2 = "ES", Id = 11 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Rome", Alpha2 = "IT", Id = 12 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "London", Alpha2 = "GB", Id = 13 });
            modelBuilder.Entity<Office>().HasData(new Office { Name = "Lund", Alpha2 = "SE", Id = 14 });

            // Assets
            //modelBuilder.Entity<Asset>().HasData(new Asset { Name = "Latitude", Model = "E7440", Type = "Laptop", Brand = "Dell", Id = 1, OfficeId = 4, EndOfLife = new DateTime(1998, 04, 03), PurchaseDate = new DateTime(1995, 04, 03) });
            //modelBuilder.Entity<Asset>().HasData(new Asset { Name = "Galaxy", Model = "A41", Type = "Mobile", Brand = "Samsung", Id = 3, OfficeId = 4, EndOfLife = new DateTime(2022, 05, 03), PurchaseDate = new DateTime(2019, 05, 03) });
            //modelBuilder.Entity<Asset>().HasData(new Asset { Name = "Iphone", Model = "13", Type = "Mobile", Brand = "Apple", Id = 4, OfficeId = 4, EndOfLife = new DateTime(2025, 09, 15), PurchaseDate = new DateTime(2022, 09, 15) });
            //modelBuilder.Entity<Asset>().HasData(new Asset { Name = "iPhone", Model = "14", Type = "Mobile", Brand = "Apple", Id = 5, OfficeId = 1, EndOfLife = new DateTime(2023, 03, 01), PurchaseDate = new DateTime(2023, 02, 01) });
            //modelBuilder.Entity<Asset>().HasData(new Asset { Name = "Latitude", Model = "X89", Type = "Laptop", Brand = "IBM", Id = 7, OfficeId = 12, EndOfLife = new DateTime(2013, 08, 01), PurchaseDate = new DateTime(2010, 08, 01) });
            //modelBuilder.Entity<Asset>().HasData(new Asset { Name = "Latitude", Model = "E7440", Type = "Laptop", Brand = "Dell", Id = 8, OfficeId = 8, EndOfLife = new DateTime(2022, 08, 01), PurchaseDate = new DateTime(2019, 08, 01) });
            //modelBuilder.Entity<Asset>().HasData(new Asset { Name = "X360", Model = "i", Type = "Laptop", Brand = "HP", Id = 9, OfficeId = 2, EndOfLife = new DateTime(2022, 06, 01), PurchaseDate = new DateTime(2019, 06, 01) });
        }
    }
}

// By Ole Victor