using MP2_Asset_tracking_EF_Ole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2_Asset_tracking_EF_Ole.Views
{
    public static class Menues
    {
        // These are the menu objects.
        // They actually do most of the controlling
        // by responding to user input.
        // They can also call each other

        // See Menu.cs and MenuItem.cs for definitions

        // Used to exit menu loops
        public static bool exit = false;

        // Create a sort menu
        private static int k = 1;
        public static Menu sortMenu = new Menu("Choises for sorting", "Sort by: ", new List<MenuItem> {
                new MenuItem("Sort by Brand", k++, "bB", Asset.sortAssetsByBrand),
                new MenuItem("Sort by Name", k++, "nN", Asset.sortAssetsByName),
                new MenuItem("Sort by Model", k++, "mM", Asset.sortAssetsByModel),
                new MenuItem("Sort by Type", k++, "tT", Asset.sortAssetsByType),
                new MenuItem("Sort by Office", k++, "oO", Asset.sortAssetsByOffice),
                new MenuItem("Sort by Price ($)", k++, "$pP", Asset.sortAssetsByPrice),
                new MenuItem("Sort by Date purchased", k++, "dD", Asset.sortAssetsByDate),
                new MenuItem("Quit menu", k++, "Qq", ()=>exit=true)
            }, Asset.listAssets);

        // Create an asset edit menu
        private static int a = 1;
        public static Menu editMenu = new Menu("Asset edit menu", "Your choise: ",
            new List<MenuItem>
            {
                new MenuItem("Add assets", a++, "aA", Asset.addAssets),
                new MenuItem("Next (press 'n' to choose next item to handle)", a++, "Nn", Asset.Next),
                new MenuItem("Previous", a++, "Pp", Asset.Previous),
                new MenuItem("Delete asset", a++, "dD", Asset.deleteAsset),
                new MenuItem("Quit", a++, "qQ", ()=>{exit=true;Asset.selected=-1;})
            }, Asset.listAssets);


        // Create an office menu
        private static int j = 1;
        public static Menu officeMenu = new Menu("Office menu", "Your choise: ",
            new List<MenuItem>
            {
                new MenuItem("List offices", j++, "lL", Office.listOffices),
                new MenuItem("Add office", j++, "aA", Office.Add),
                new MenuItem("Next (press 'n' to choose next item to handle)", j++, "Nn", Office.Next),
                new MenuItem("Previous", j++, "Pp", Office.Previous),
                new MenuItem("Delete office", j++, "dD", Office.Delete),
                new MenuItem("Quit", j++, "qQ", ()=>{exit=true;Office.selected=-1; })
            }, Office.listOffices);

        // Create a main menu
        private static int i = 1;
        public static Menu mainMenu = new Menu("Main menu", "Your choise: ", 
            new List<MenuItem>
            {
                new MenuItem("List assets", i++, "lL", Asset.listAssets),
                new MenuItem("Sort assets", i++, "sS", sortMenu.Perform),
                new MenuItem("Edit assets (Add, delete, change...)", i++, "Ee", editMenu.Perform),
                new MenuItem("Handle offices", i++, "Oo", officeMenu.Perform),
                new MenuItem("Quit program", i++, "qQ", ()=>exit=true)
            }, Asset.listAssets);
    }
}

// By Ole Victor