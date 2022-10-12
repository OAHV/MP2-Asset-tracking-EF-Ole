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
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public int Numeric { get; set; }
        public string CurrencySymbol { get; set; }
        [ForeignKey("CurrencySymbol")]
        public Currency Currency { get; set; }
        public List<Office> Offices { get; set; }
    }
}
