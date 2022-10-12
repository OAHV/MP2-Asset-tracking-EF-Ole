using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using MP2_Asset_tracking_EF_Ole.Models;
using Microsoft.EntityFrameworkCore.Design;



namespace MP2_Asset_tracking_EF_Ole.DB
{
    internal class AssetsDB : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Office> Officies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        string connectionString = "Data Source=OLE-LAPTOP;Initial Catalog=AssetTracking;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Currency>().HasData(new Currency { Name="US Dollar", Symbol="USD", ExchangeFactor=1});
        }
    }
}
