using MP2_Asset_tracking_EF_Ole.DB;
using MP2_Asset_tracking_EF_Ole.Views;
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
        public List<Asset> Assets { get; set; }

        public static List<Office> Offices = new List<Office>();
        public static string Header = "Office".PadRight(15) + "Country";
        public static string Footer = "";
        // The selected task is to be highlighted (initially none selected)
        private static int selected = -1;

        public void Display(int row = 0)
        {
            // Special case:
            // Single row print (not a list) at a specific row on screen
            if (row != 0)
            {
                CursorControl.PushCursor();
                CursorControl.curSet(row, 0);
            }

            Console.WriteLine((Name + " (" + Country.Name + ")").PadRight(Console.WindowWidth - 1));

            // Special case: Restore cursor row
            if (row != 0) CursorControl.PopCursor();
        }

        static public void listOffices()
        {
            // Clear lower part of screen
            ConsoleScreen.clearLowerPart(ConsoleScreen.lowerPartOfScreen - 2);

            // Print higlighted header
            CursorControl.highLight();
            Console.WriteLine(Header);
            CursorControl.highLight(false);

            // Print list of offices
            foreach (Office o in Offices)
            {
                // The user selected task is yellow
                if (selected >= 0 && o == Offices[selected]) CursorControl.highLight(true, ConsoleColor.Yellow);

                o.Display();

                Console.ResetColor();
            }

            // Print footer
            CursorControl.highLight();
            Footer = "Total " + Offices.Count.ToString() + " offices";
            Console.WriteLine(Footer);
            CursorControl.highLight(false);
        }

        public static void Add()
        {
            char ok = '-';      // User input
            Office newOffice = new Office() { Name = "-no office-", Country = new Country() { Name = "-no country-" } };

            // Where to display the new asset template as it is built
            //int displayAtRow = ConsoleScreen.lowerPartOfScreen - 2;
            int displayAtRow = 1;

            Console.Clear();

            // Display template asset as it is built
            newOffice.Display(displayAtRow);

            Console.WriteLine("Add office");

            // Clear screen below for input dialog
            //ConsoleScreen.clearLowerPart(ConsoleScreen.lowerPartOfScreen - 2);
            ConsoleScreen.clearLowerPart(displayAtRow + 1);


            // User input of Name and country
            newOffice.Country = ConsoleScreen.readCountryFromList("Country: ", "Not a Country. Please try again: ");
            newOffice.Display(displayAtRow);
            newOffice.Name = ConsoleScreen.readString("Office name: ", "Not a name. Please try again: ");
            newOffice.Display(displayAtRow);

            // Confirm by user
            Console.Write("Add new office to list (y/n): ");
            while (ok == '-')
            {
                ok = Console.ReadKey().KeyChar;
                switch (ok)
                {
                    case 'y':
                        // Write new asset to database
                        using (var db = new AssetsDB())
                        {
                            db.Officies.Update(newOffice);
                            db.SaveChanges();
                        }
                        // Add new asset to list
                        Offices.Add(newOffice);
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
            Console.Clear();
        }

        public static void Next()
        {
            // Select the next task
            if (selected < Offices.Count - 1) selected++;
        }

        public static void Previous()
        {
            // Select the previous task
            if (selected > 0) selected--;
        }

        public static void Delete()
        {
            // Check if office is in use (has any tasks)
            if (Offices[selected].Assets != null)
            {
                ConsoleScreen.errorDisplay("Office is in use (has assets) - can't delete");
                return;
            }
            // Remove the asset from the database
            using (var db = new AssetsDB())
            {
                db.Officies.Remove(Offices[selected]);
                db.SaveChanges();
            }
            // Remove the selected task from the list of tasks
            Offices.Remove(Offices[selected]);
            // Recalculate the selection and the footer
            if (selected > Offices.Count - 1) selected = Offices.Count - 1;
            Footer = "Total " + Offices.Count.ToString() + " offices";
        }

    }


}
