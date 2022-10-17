using MP2_Asset_tracking_EF_Ole.DB;
using MP2_Asset_tracking_EF_Ole.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MP2_Asset_tracking_EF_Ole.Models
{
    public class Asset
    {
        // Asset properties
        public int Id { get; set; }         // Key
        public string Name { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int OfficeId { get; set; }   // Foreign key
        [ForeignKey("OfficeId")]
        public Office Office { get; set; }
        public DateTime EndOfLife { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int DollarPrice { get; set; }

        // The selected task is to be highlighted (initially none selected)
        public static int selected = -1;

        // The list of assets
        public static List<Asset> Assets = new List<Asset>();

        // Constructor
        public Asset(string name = "-name-", string model = "-model-", string type = "-type-", string brand = "-brand-", int dollarPrice = 0)
        {
            Name = name;
            Model = model;
            Type = type;
            Brand = brand;
            // A new asset will initially refere to this default office
            Office = new Office()
            {
                Name = "-office-",
                // A new office will initially refere to this default country
                Country = new Country()
                {
                    Name = "-country-",
                    Alpha3 = "-country-",
                    // A new country will initially refere to this nonsence currency
                    Currency = new Currency() { Symbol = "-" }
                }
            };
            EndOfLife = new DateTime();
            PurchaseDate = new DateTime();
            DollarPrice = dollarPrice;
        }

        // List assets on screen
        public static void listAssets()
        {

            List<string> uniqueCountries = new List<string>();
            List<string> uniqueOffices = new List<string>();
            double dollarSum = 0;

            // Clear lower part of screen
            ConsoleScreen.clearLowerPart(ConsoleScreen.lowerPartOfScreen);

            // Print higlighted header
            CursorControl.highLight();
            Console.WriteLine(
                "Brand".PadRight(10)
                + "Name".PadRight(10)
                + "Model".PadRight(10)
                + "Type".PadRight(10)
                + "Office".PadRight(11)
                + "Country".PadRight(10)
                + "Price".PadRight(9)
                //+ "   $-Price".PadLeft(7)
                + "   " + "Purchased".PadRight(12)
                + "End-of-Life".PadRight(12)
                );
            CursorControl.highLight(false);

            // Print list of assets
            foreach (Asset a in Assets)
            {
                uniqueOffices.Add(a.Office.Name);
                uniqueCountries.Add(a.Office.Country.Name);
                dollarSum += a.DollarPrice;

                // The user selected task is yellow
                if (selected >= 0 && a == Assets[selected]) CursorControl.highLight(true, ConsoleColor.Yellow);

                a.Display();

                Console.ResetColor();
            }
            // Print footer
            CursorControl.highLight();
            Console.WriteLine(
                Assets.Count
                + " assets of total value $"
                + dollarSum
                + " in "
                + uniqueOffices.Distinct().Count()
                + " offices in "
                + uniqueCountries.Distinct().Count()
                + " countries"
                .PadRight(50)
             );
            CursorControl.highLight(false);
        }

        // Change individual values of a specific asset
        public static void Edit()
        {
            // To be implemented
        }

        // Add new assets to list by user input
        public static void addAssets()
        {
            char ok = '-';      // User input
            Asset newAsset = new Asset();

            // Where to display the new asset template as it is built
            int displayAtRow = 1;

            Console.Clear();

            // Display template asset as it is built
            // The user can see the values beeing filled in
            newAsset.Display(displayAtRow);

            // Display template asset as it is built
            Console.WriteLine("Add asset");

            // Clear screen below for input dialog
            ConsoleScreen.clearLowerPart(displayAtRow + 1);

            // User input
            newAsset.Office = ConsoleScreen.readOfficeFromList("Office: ", "Not an Office. Please try again: ");
            newAsset.Display(displayAtRow);
            newAsset.Type = ConsoleScreen.readString("Type: ", "Not a Type. Please try again: ");
            newAsset.Display(displayAtRow);
            newAsset.Brand = ConsoleScreen.readString("Brand: ", "Not a Brand. Please try again: ");
            newAsset.Display(displayAtRow);
            newAsset.Name = ConsoleScreen.readString("Name: ", "No input. Please try again: ");
            newAsset.Display(displayAtRow);     // Update asset template on screen
            newAsset.Model = ConsoleScreen.readString("Model: ", "No input. Please try again: ");
            newAsset.Display(displayAtRow);
            newAsset.DollarPrice = ConsoleScreen.readInt("Price ($): ", "Not a number. Please try again: ");
            newAsset.Display(displayAtRow);
            newAsset.PurchaseDate = ConsoleScreen.readDate("Purchase date: ", "Not a date. Please try again: ");
            newAsset.Display(displayAtRow);

            // Calculate End-of-Life (three years after Purchase)
            newAsset.EndOfLife = newAsset.PurchaseDate.AddYears(3);
            newAsset.Display(displayAtRow);

            // Confirm by user
            Console.Write("Add new asset to list (y/n): ");
            while (ok == '-')
            {
                ok = Console.ReadKey().KeyChar;
                switch (ok)
                {
                    case 'y':
                        // Write new asset to database
                        using (var db = new AssetsDB())
                        {
                            db.Assets.Update(newAsset);
                            db.SaveChanges();
                        }
                        // Add new asset to list
                        Assets.Add(newAsset);
                        break;
                    case 'n':
                        break;
                    default:
                        Console.CursorLeft = 0;
                        ConsoleScreen.errorDisplay("Pleas answer 'y' or 'n': ");
                        ok = '-';
                        break;
                }
            }
        }

        // Delete an asset by user choise
        public static void deleteAsset()
        {
            // Remove the asset from the database
            using (var db = new AssetsDB())
            {
                db.Assets.Remove(Assets[selected]);
                db.SaveChanges();
            }
            // Remove the asset in focus from the list
            Assets.RemoveAt(selected);

            // If it was the last asset in the list, update to the now last item
            if (selected > Assets.Count - 1) selected = Assets.Count - 1;
        }

        // Method for displaying an asset as a row on screen
        public void Display(int row = 0)
        {
            // Special case:
            // Single row print (not a list) at a specific row on screen
            if (row != 0)
            {
                // Save cursor position on the stack
                CursorControl.PushCursor();
                // Set cursor position
                CursorControl.curSet(row, 0);
            }

            // Print this asset on screen
            Console.Write(
                Brand.PadRight(10)      // Brand
                + Name.PadRight(10)         // Name
                + Model.PadRight(10)      // Model
                + Type.PadRight(10)       // Type
                + Office.Name.PadRight(11)  // Office
                // Country found by office
                + Office.Country.Alpha3.PadRight(10) 
                // Local currency found by office name
                + Office.Country.Currency.Symbol.PadRight(3) + " " 
                // Price in local currency found by office name
                + Office.Country.Currency.fromDollar(DollarPrice).ToString("0").PadLeft(7) + " "
                // Date of purchase
                + PurchaseDate.ToString("d").PadRight(12)
                );

            // Highlight End-of-Life date in yellow or red depending on date
            if (EndOfLife < DateTime.Now.AddMonths(6)) Console.ForegroundColor = ConsoleColor.Yellow;
            if (EndOfLife < DateTime.Now.AddMonths(3)) Console.ForegroundColor = ConsoleColor.Red;
            // Display date - reset color
            Console.WriteLine(EndOfLife.ToString("d").PadRight(12));
            CursorControl.highLight(false);

            // Special case: Restore cursor row
            if (row != 0) CursorControl.PopCursor();
        }

        public static void Next()
        {
            // Select the next task
            if (selected < Assets.Count - 1) selected++;
        }

        public static void Previous()
        {
            // Select the previous task
            if (selected > 0) selected--;
        }

        public static void sortAssetsByOffice()
        {
            Assets = Assets.OrderBy(x => x.Office.Name).ThenBy(x => x.PurchaseDate).ToList();
        }

        public static void sortAssetsByPrice()
        {
            Assets = Assets.OrderBy(x => x.DollarPrice).ThenBy(x => x.PurchaseDate).ToList();
        }

        public static void sortAssetsByDate()
        {
            Assets = Assets.OrderBy(x => x.PurchaseDate).ToList();
        }

        public static void sortAssetsByName()
        {
            Assets = Assets.OrderBy(x => x.Name).ThenBy(x => x.PurchaseDate).ToList();
        }

        public static void sortAssetsByModel()
        {
            Assets = Assets.OrderBy(x => x.Model).ThenBy(x => x.PurchaseDate).ToList();
        }

        public static void sortAssetsByType()
        {
            Assets = Assets.OrderBy(x => x.Type).ThenBy(x => x.PurchaseDate).ToList();
        }
        public static void sortAssetsByBrand()
        {
            Assets = Assets.OrderBy(x => x.Brand).ThenBy(x => x.PurchaseDate).ToList();
        }

    }
}

// By Ole Victor