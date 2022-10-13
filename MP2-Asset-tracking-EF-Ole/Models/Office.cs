using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2_Asset_tracking_EF_Ole.Models
{
    public class Office
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Alpha2 { get; set; }
        [ForeignKey("Alpha2")]
        public Country Country { get; set; }
        public List<Asset> assets { get; set; }

        public static List<Office> Offices = new List<Office>();

        public void Display()
        {
            Console.WriteLine("Office: " + Name + " " + " (" + Alpha2 + ")");
        }
    }

    
}
