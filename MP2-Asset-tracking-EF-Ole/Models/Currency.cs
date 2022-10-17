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
        // This class handles currencies and exchanging between them

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

        public static List<Currency> Currencies = new List<Currency>();

        // Convert from Dollar to this currency
        public double fromDollar(double dollarAmount)
        {
            return dollarAmount * ExchangeFactor;
        }
    }
}
