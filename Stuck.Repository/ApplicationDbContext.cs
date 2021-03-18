
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stuck.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stuck.Repository
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public Transaction Transactions { get; set; }


        public DbSet<Security> Securities { get; set; } // to be removed later

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }






        //public DbSet<OrderType> OrderTypes { get; set; }


        //public DbSet<Order> Orders { get; set; }


        //public DbSet<BrokerageAccount> BrokerageAccounts { get; set; }
        //public DbSet<MarketIndex> MarketIndexes { get; set; }

        //public DbSet<Position> Positions { get; set; }

        // public DbSet<MutualFund> MutualFunds { get; set; }
        //public DbSet<WatchList> WatchLists { get; set; }
        //public DbSet<CompanyProfile> CompanyProfiles { get; set; }
        //public DbSet<TradingInformation> TradingInformation { get; set; }
        //public DbSet<ApplicationUser> ApplicationUser { get; set; }




    }
}
