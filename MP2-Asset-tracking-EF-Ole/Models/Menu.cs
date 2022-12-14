using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MP2_Asset_tracking_EF_Ole.Views;

namespace MP2_Asset_tracking_EF_Ole.Models
{
    // Definition of a menu to display on screen
    public class Menu : ListOfItems
    {
        // The menu is a header, a list of menu items and a prompt string
        // THere is also a pointer to a function "lister" to display the appropriate list below the menu

        // List of menu items ----------------------------------------
        List<MenuItem> m = new List<MenuItem>();

        // Constructor
        public Menu(string header, string promptString, List<MenuItem> menuItems, Action lister)
        {
            // Header over the menu
            Header = header;
            // Prompt string below the menu
            PromptString = promptString;
            // A list of menu items
            MenuItems = menuItems;
            // A function to call to display the appropriate list below the menu
            Lister = lister;
        }

        // Menu ------------------------------------------------------

        // List of rows with choises
        public List<MenuItem> MenuItems;
        // Reference to a method for displaying the proper list for this menu
        public Action Lister;

        public string PromptString;

        // The menu is called by this function
        public void Perform()
        {

            // While user has not choosen to exit the menu
            while (!Menues.exit)
            {
                //Print the menu with header, items and prompt
                Print();
                Input();
            }
            // After user has chosen to exit the menu
            // Clear screen
            Console.Clear();

            // Reset to false before the actual exit
            Menues.exit = false;
        }

        // This is to read user input characters
        public void Input()
        {
            // Read user input (user menu choise)
            char inp = ' ';
            bool found = false;

            // Set cursor to input position - erase the rest of the row
            CursorControl.PushCursor();
            Console.Write(" ".PadRight(50));

            // Call the lister function to display the appropriate list below the menu
            Lister();

            // Restore the cursor to the menu input position
            CursorControl.restoreCur();

            // Read input key
            inp = Console.ReadKey().KeyChar;
            foreach (MenuItem item in MenuItems)
            {
                // Find a menu item that matches the key
                if (item.Choises.Contains(inp))
                {
                    // Found: Perform menu action and break out of loop
                    item.Perform();
                    found = true;
                    // Display the appropriate list below the menu (after performing the action)
                    Lister();
                    break;
                }
            }
            // If no valid input - Error message
            if (!found) ConsoleScreen.errorDisplay("Invalid input...");
        }

        // List of items ---------------------------------------------
        public override void Print()
        {
            // Top left of the screen
            CursorControl.curSet();

            // Display header, items and prompt string
            CursorControl.highLight();
            Console.WriteLine(Header);
            CursorControl.highLight(false);

            foreach (var item in MenuItems) { item.Display(); }

            Console.Write(PromptString);
        }
    }
}

// By Ole Victor