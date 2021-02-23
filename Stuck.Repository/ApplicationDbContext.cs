﻿
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
        public DbSet<Stocks> Stockss { get; set; }
        public DbSet<Exchange> Exchange { get; set; }
        public DbSet<BrokerageAccount> BrokerageAccounts { get; set; }
        public DbSet<MarketIndex> MarketIndexes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Security> Securities { get; set; }
        public DbSet<MutualFund> MutualFunds { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }
        public DbSet<CompanyProfile> CompanyProfiles { get; set; }
        public DbSet<TradingInformation> TradingInformation { get; set; }
        public DbSet<UserRegistration> SignUp { get; set; }

    }
}
