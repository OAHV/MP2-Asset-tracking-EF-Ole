using MP2_Asset_tracking_EF_Ole.DB;
using MP2_Asset_tracking_EF_Ole.Views;
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

        public static List<Asset> Assets = new List<Asset>();

        public Asset(string name, string model, string type, string brand, int dollarPrice)
        {
            Name = name;
            Model = model;
            Type = type;
            Brand = brand;
            Office = new Office() { Name = "No office", Country = new Country() { Name = "-country-", Currency = new Currency() { Symbol = "-" } } };
            EndOfLife = new DateTime();
            PurchaseDate = new DateTime();
            DollarPrice = dollarPrice;
        }

        // List assets on screen
        public static void listAssets()
        {
            // Clear lower part of screen
            ConsoleScreen.clearLowerPart(ConsoleScreen.lowerPartOfScreen);

            // Print higlighted header
            CursorControl.highLight();
            Console.WriteLine(
                "Name".PadRight(10)
                + "Model".PadRight(10)
                + "Type".PadRight(10)
                + "Brand".PadRight(10)
                + "Office".PadRight(11)
                + "Country".PadRight(10)
                + "Price".PadLeft(10)
                + "   $-Price".PadLeft(7)
                + "   " + "Purchased".PadRight(12)
                + "End-of-Life".PadRight(12)
                );
            CursorControl.setAlertColor();

            // Print list of assets
            foreach (Asset a in Assets) a.Display();
        }

        // Add new assets to list by user input
        public static void addAssets()
        {
            char ok = '-';      // User input
            Asset newAsset = new Asset("-name-", "-model-", "-type-", "-brand-", 0);

            // Where to display the new asset template as it is built
            int displayAtRow = ConsoleScreen.lowerPartOfScreen - 2;
            newAsset.Display(displayAtRow);

            // Clear screen below for input dialog
            ConsoleScreen.clearLowerPart(ConsoleScreen.lowerPartOfScreen);

            // Display template asset as it is built
            Console.WriteLine("Add asset");

            // User input of Name, Model, Price, Purchase date, Type and Brand
            newAsset.Name = ConsoleScreen.readString("Name: ", "No input. Please try again: ");
            newAsset.Display(displayAtRow);     // Update asset template on screen
            newAsset.Model = ConsoleScreen.readString("Model: ", "No input. Please try again: ");
            newAsset.Display(displayAtRow);
            newAsset.Type = ConsoleScreen.readString("Type: ", "Not a Type. Please try again: ");
            newAsset.Display(displayAtRow);
            newAsset.Brand = ConsoleScreen.readString("Brand: ", "Not a Brand. Please try again: ");
            newAsset.Display(displayAtRow);
            newAsset.Office = ConsoleScreen.readOfficeFromList("Office: ", "Not an Office. Please try again: ");
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
            int i = 0;      // Index
            char c = ' ';   // User input choise

            // Clear screen, save cursor and list assets
            Console.Clear();
            CursorControl.PushCursor();
            listAssets();

            // At top of screen, ask for user choise
            CursorControl.restoreCur();
            Console.WriteLine("Delete asset");
            Console.Write("Choose asset (n=next, p=previous, d=delete, q=quit): ");
            CursorControl.PushCursor();

            // Display which asset is in focus below user input
            Assets[i].Display(3);

            // Input user choise (exit on 'q')
            CursorControl.restoreCur();
            while ((c = Console.ReadKey().KeyChar) != 'q')
            {
                switch (c)
                {
                    case 'n':
                        // Next: Switch asset in focus (down), if not at end-of-list
                        if (i < Assets.Count - 1) i++;
                        break;
                    case 'p':
                        // Previous: Switch asset in focus (up), if not at start-of-list
                        if (i > 0) i--;
                        break;
                    case 'd':
                        // Remove the asset from the database
                        using (var db = new AssetsDB())
                        {
                            db.Assets.Remove(Assets[i]);
                            db.SaveChanges();
                        }
                        // Delete: Remove the asset in focus from the list
                        Assets.RemoveAt(i);
                        // If it was the last asset in the list, update to the now last item
                        if (i > Assets.Count - 1) i = Assets.Count - 1;
                        // Update the list of assets on screen below
                        listAssets();
                        break;
                    default:
                        // Any other input
                        ConsoleScreen.errorDisplay("Faulty input");
                        break;
                }

                // If list is now empty: Exit
                if (Assets.Count == 0) break;

                // Display the asset now in focus
                Assets[i].Display(3);

                // Restore cursor to input point and erase rest of row
                CursorControl.restoreCur();
                Console.Write(" ".PadRight(Console.WindowWidth));
                CursorControl.restoreCur();
            }
        }

        // Method for displaying an asset as a row on screen

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
                Office.Name.PadRight(11) +  // Office
                                            // Country found by office
                Office.Country.Name.PadRight(10) +
                // Local currency found by office name
                (Office.Country.Currency.Symbol + " " +
                // Price in local currency found by office name
                Office.Country.Currency.fromDollar(DollarPrice).ToString("0.00")).PadLeft(10) +
                ("$" + DollarPrice).PadLeft(10) + // Price i dollars
                "   "
                +
                // Date of purchase
                PurchaseDate.ToString("d").PadRight(12)
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

        //        new MenuItem("Sort by Office", k++, "oO", Asset.sortAssetsByOffice),
        //        new MenuItem("Sort by Price", k++, "pP", Asset.sortAssetsByPrice),
        //        new MenuItem("Sort by Date purchased", k++, "dD", Asset.sortAssetsByDate),
        //        new MenuItem("Sort by Date Name", k++, "nN", Asset.sortAssetsByName),
        //        new MenuItem("Sort by Date Model", k++, "mM", Asset.sortAssetsByModel),
        //        new MenuItem("Sort by Date Type", k++, "tT", Asset.sortAssetsByType),
        //        new MenuItem("Sort by Date Brand", k++, "bB", Asset.sortAssetsByBrand),

        public static void sortAssetsByOffice()
        {
            Assets = Assets.OrderBy(x => x.Office.Name).ToList();
        }


        public static void sortAssetsByPrice()
        {
            Assets = Assets.OrderBy(x => x.DollarPrice).ToList();
        }

        public static void sortAssetsByDate()
        {
            Assets = Assets.OrderBy(x => x.PurchaseDate).ToList();
        }

        public static void sortAssetsByName()
        {
            Assets = Assets.OrderBy(x => x.Name).ToList();
        }

        public static void sortAssetsByModel()
        {
            Assets = Assets.OrderBy(x => x.Model).ToList();
        }

        public static void sortAssetsByType()
        {
            Assets = Assets.OrderBy(x => x.Type).ToList();
        }
        public static void sortAssetsByBrand()
        {
            Assets = Assets.OrderBy(x => x.Brand).ToList();
        }

    }
}
