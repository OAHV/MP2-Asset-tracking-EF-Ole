using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2_Asset_tracking_EF_Ole.Models
{
    public class Country
    {
        
        public string Name { get; set; }
        [Key]
        public string Alpha2 { get; set; }              // Unique two-letter id as key
        public string Alpha3 { get; set; }              // Unique three-letter id
        public int Numeric { get; set; }                // Unique numeric id
        public string CurrencySymbol { get; set; }      // Unique currency symbol as Foreign key
        [ForeignKey("CurrencySymbol")]
        public Currency Currency { get; set; }          // The currency of this country
        public List<Office> Offices { get; set; }       // List of all offices in this country

        // List of all countries
        public static List<Country> Countries = new List<Country>();

        // Display this currency on screen (in a list)
        public void Display()
        {
            Console.WriteLine(Alpha2 + "-" + Alpha3 + "-" + Numeric.ToString().PadRight(4) + " " + Name + " (Currency: " + CurrencySymbol + ")");
        }
    }
}

// By Ole Victor