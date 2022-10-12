using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2_Asset_tracking_EF_Ole.Models
{
    public class Currency
    {
        // This class handles currencies and exchanges between them
        //public Currency(string name, string symbol, string country, double exchangeFactor)
        //{
        //    Name = name;
        //    Symbol = symbol;
        //    Country = country;
        //    ExchangeFactor = exchangeFactor;
        //}

        public string Name { get; set; }
        [Key]
        public string Symbol { get; set; }
        public List<Country> Countries { get; set; }
        public double ExchangeFactor { get; set; }

        // Convert from this currency to Dollar
        public double toDollar(double amount)
        {
            return amount / ExchangeFactor;
        }

        // Convert from Dollar to this currency
        public double fromDollar(double dollarAmount)
        {
            return dollarAmount * ExchangeFactor;
        }

        // A list of all currencies avaliable
        /*
        // public static List<Currency> currencies = new List<Currency>
        {
            new Currency("Danish Crown", "DKK", "Denmark", 6.5),
            new Currency("Swedish Crown", "SEK", "Sweden", 9.5),
            new Currency("US Dollar", "$", "USA", 1.2),
            new Currency("UK Pound", "£", "England", 0.8),
            new Currency("Euro", "EUR", "EU", 0.9)
        };
        */
    }
}
