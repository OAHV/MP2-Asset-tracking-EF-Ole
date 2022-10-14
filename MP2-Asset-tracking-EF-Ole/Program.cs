﻿using MP2_Asset_tracking_EF_Ole.DB;
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


//using (var db = new AssetsDB())
//{
//    db.Assets.UpdateRange(Asset.Assets);
//    db.SaveChanges();
//}
