using MP2_Asset_tracking_EF_Ole.DB;
using MP2_Asset_tracking_EF_Ole.Models;
using Microsoft.EntityFrameworkCore.Design;
using MP2_Asset_tracking_EF_Ole;
using MP2_Asset_tracking_EF_Ole.Views;

// Get all data from DB into the lists
using ( var db = new AssetsDB())
{
    Asset.Assets = db.Assets.ToList();
    Country.Countries = db.Countries.ToList();
    Currency.Currencies = db.Currencies.ToList();
    Office.Offices = db.Officies.ToList();
}

// Fire off the user interface
Menues.mainMenu.Perform();

// Good bye
Console.Clear();
Console.CursorTop = Console.WindowHeight / 3;
Console.WriteLine("Thank you for using my app!\n\nOle Victor\n\n\n\n\n\n\n\n\n");


// By Ole Victor