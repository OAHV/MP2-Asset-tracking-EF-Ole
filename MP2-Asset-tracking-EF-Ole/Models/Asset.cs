using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2_Asset_tracking_EF_Ole.Models
{
    public class Asset
    {
        // Asset properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
        public DateTime EndOfLife { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int DollarPrice { get; set; }

        // Method for displaying an asset as a row on screen
        /*
        public void Display(int row = 0)
        {
            // Special case:
            // Single row print (not a list) at a specific row on screen
            if (row != 0)
            {
                CursorControl.PushCursor();
                CursorControl.curSet(row, 0);
            }

            // Print this asset on screen
            Console.Write(
                Name.PadRight(10) +         // Name
                Model.PadRight(10) +        // Model
                Type.PadRight(10) +         // Type
                Brand.PadRight(10) +        // Brand
                Kontor.PadRight(11) +       // Office
                                            // Country found by office
                Office.OfficeList.Find(x => x.Name == Kontor).Country.PadRight(10) +
                // Local currency found by office name
                (Office.OfficeList.Find(x => x.Name == Kontor).Currency.Symbol + " " +
                // Price in local currency found by office name
                Office.OfficeList.Find(x => x.Name == Kontor).Currency.fromDollar(Price).ToString("0.00")).PadLeft(10) +
                ("$" + Price).PadLeft(10) + // Price i dollars
                "   " +
                // Date of purchase
                PurchaseDate.ToString("d").PadRight(12));

            // Highlight End-of-Life date in yellow or red depending on date
            if (EndOfLife < DateTime.Now.AddMonths(6)) Console.ForegroundColor = ConsoleColor.Yellow;
            if (EndOfLife < DateTime.Now.AddMonths(3)) Console.ForegroundColor = ConsoleColor.Red;
            // Display date - reset color
            Console.WriteLine(EndOfLife.ToString("d").PadRight(12));
            CursorControl.highLight(false);

            // Special case: Restore cursor row
            if (row != 0) CursorControl.PopCursor();
        }
        */
    }
}
