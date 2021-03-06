﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stuck.Repository;

namespace Stuck.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210302095818_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SecurityWatchList", b =>
                {
                    b.Property<int>("SecuritiesId")
                        .HasColumnType("int");

                    b.Property<int>("WatchListsId")
                        .HasColumnType("int");

                    b.HasKey("SecuritiesId", "WatchListsId");

                    b.HasIndex("WatchListsId");

                    b.ToTable("SecurityWatchList");
                });

            modelBuilder.Entity("Stuck.Entity.BrokerageAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CashTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<bool>("IsRetirement")
                        .HasColumnType("bit");

                    b.Property<decimal>("MarginBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PositionsTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("WatchListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.HasIndex("WatchListId");

                    b.ToTable("BrokerageAccounts");
                });

            modelBuilder.Entity("Stuck.Entity.CompanyProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Auditor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoardOfDirectors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanySecretay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateListed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfIncorporation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarketClassification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NatureOfBusiness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OfficalClose")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OfficialOpen")
                        .HasColumnType("datetime2");

                    b.Property<string>("Regristra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyProfiles");
                });

            modelBuilder.Entity("Stuck.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Stuck.Entity.DataPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SecurityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SecurityId");

                    b.ToTable("DataPoint");
                });

            modelBuilder.Entity("Stuck.Entity.Exchange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Exchange");
                });

            modelBuilder.Entity("Stuck.Entity.MarketIndex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("MarketIndexes");
                });

            modelBuilder.Entity("Stuck.Entity.MutualFund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Change")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Last")
                        .HasColumnType("int");

                    b.Property<int>("MorningStarRating")
                        .HasColumnType("int");

                    b.Property<decimal>("PercentChange")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("RetievalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Shares")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MutualFunds");
                });

            modelBuilder.Entity("Stuck.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrokerageAccountId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfShares")
                        .HasColumnType("int");

                    b.Property<int?>("OrderTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal (18,2)");

                    b.Property<int?>("SecurityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrokerageAccountId");

                    b.HasIndex("OrderTypeId");

                    b.HasIndex("SecurityId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Stuck.Entity.OrderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderTypes");
                });

            modelBuilder.Entity("Stuck.Entity.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrokerageAccountId")
                        .HasColumnType("int");

                    b.Property<int>("SecurityId")
                        .HasColumnType("int");

                    b.Property<decimal>("Shares")
                        .HasColumnType("decimal (18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal (18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BrokerageAccountId");

                    b.HasIndex("SecurityId")
                        .IsUnique();

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Stuck.Entity.Security", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Change")
                        .HasColumnType("decimal (18,2)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Last")
                        .HasColumnType("int");

                    b.Property<decimal>("PercentChange")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("RetievalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Shares")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Securities");
                });

            modelBuilder.Entity("Stuck.Entity.Stocks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AverageVolume")
                        .HasColumnType("decimal (18,2)");

                    b.Property<decimal>("Change")
                        .HasColumnType("decimal (18,2)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DayHigh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DayLow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Dividend")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ExchangeId")
                        .HasColumnType("int");

                    b.Property<int>("Lastings")
                        .HasColumnType("int");

                    b.Property<decimal>("MarketCap")
                        .HasColumnType("decimal (18,2)");

                    b.Property<int?>("MutualFundId")
                        .HasColumnType("int");

                    b.Property<decimal>("Opening")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PercentChange")
                        .HasColumnType("decimal (18,2)");

                    b.Property<DateTime>("RetievalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SecurityId")
                        .HasColumnType("int");

                    b.Property<decimal>("Shares")
                        .HasColumnType("decimal (18,2)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Trades")
                        .HasColumnType("decimal (18,2)");

                    b.Property<decimal>("Volume")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("YearHigh")
                        .HasColumnType("decimal (18,2)");

                    b.Property<decimal>("YearLow")
                        .HasColumnType("decimal (18,2)");

                    b.Property<decimal>("_52WeeksHigh")
                        .HasColumnType("decimal (18,2)");

                    b.Property<decimal>("_52WeeksLow")
                        .HasColumnType("decimal (18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ExchangeId");

                    b.HasIndex("MutualFundId");

                    b.HasIndex("SecurityId");

                    b.ToTable("Stockss");
                });

            modelBuilder.Entity("Stuck.Entity.TradingInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("MarketCap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MarketClassification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OfficalClose")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OfficialOpen")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SharesOutstanding")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SubSector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TickerSymbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradingName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TradingInformation");
                });

            modelBuilder.Entity("Stuck.Entity.WatchList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("WatchLists");
                });

            modelBuilder.Entity("Stuck.Repository.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SecurityWatchList", b =>
                {
                    b.HasOne("Stuck.Entity.Security", null)
                        .WithMany()
                        .HasForeignKey("SecuritiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stuck.Entity.WatchList", null)
                        .WithMany()
                        .HasForeignKey("WatchListsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Stuck.Entity.BrokerageAccount", b =>
                {
                    b.HasOne("Stuck.Entity.Customer", "Customer")
                        .WithMany("BrokerageAccounts")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stuck.Entity.WatchList", "WatchList")
                        .WithMany()
                        .HasForeignKey("WatchListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("WatchList");
                });

            modelBuilder.Entity("Stuck.Entity.DataPoint", b =>
                {
                    b.HasOne("Stuck.Entity.Security", null)
                        .WithMany("DataPoints")
                        .HasForeignKey("SecurityId");
                });

            modelBuilder.Entity("Stuck.Entity.Order", b =>
                {
                    b.HasOne("Stuck.Entity.BrokerageAccount", "BrokerageAccount")
                        .WithMany("Orders")
                        .HasForeignKey("BrokerageAccountId");

                    b.HasOne("Stuck.Entity.OrderType", "OrderType")
                        .WithMany("Orders")
                        .HasForeignKey("OrderTypeId");

                    b.HasOne("Stuck.Entity.Security", "Security")
                        .WithMany("Orders")
                        .HasForeignKey("SecurityId");

                    b.Navigation("BrokerageAccount");

                    b.Navigation("OrderType");

                    b.Navigation("Security");
                });

            modelBuilder.Entity("Stuck.Entity.Position", b =>
                {
                    b.HasOne("Stuck.Entity.BrokerageAccount", "BrokerageAccount")
                        .WithMany("Positions")
                        .HasForeignKey("BrokerageAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stuck.Entity.Security", "Security")
                        .WithOne("Position")
                        .HasForeignKey("Stuck.Entity.Position", "SecurityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BrokerageAccount");

                    b.Navigation("Security");
                });

            modelBuilder.Entity("Stuck.Entity.Stocks", b =>
                {
                    b.HasOne("Stuck.Entity.Exchange", "Exchange")
                        .WithMany()
                        .HasForeignKey("ExchangeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Stuck.Entity.MutualFund", "MutualFund")
                        .WithMany("Stocks")
                        .HasForeignKey("MutualFundId");

                    b.HasOne("Stuck.Entity.Security", "Security")
                        .WithMany("Stocks")
                        .HasForeignKey("SecurityId");

                    b.Navigation("Exchange");

                    b.Navigation("MutualFund");

                    b.Navigation("Security");
                });

            modelBuilder.Entity("Stuck.Entity.BrokerageAccount", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Positions");
                });

            modelBuilder.Entity("Stuck.Entity.Customer", b =>
                {
                    b.Navigation("BrokerageAccounts");
                });

            modelBuilder.Entity("Stuck.Entity.MutualFund", b =>
                {
                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("Stuck.Entity.OrderType", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Stuck.Entity.Security", b =>
                {
                    b.Navigation("DataPoints");

                    b.Navigation("Orders");

                    b.Navigation("Position");

                    b.Navigation("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
