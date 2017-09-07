using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MatterCentral.Models;

namespace MatterCentral.Data
{
    public class ALCContext : DbContext
    {
        public ALCContext(DbContextOptions<ALCContext> options) 
                : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<OffloadPoint> OffloadPoints { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<PaymentTerm> PaymentTerms { get; set; }
        public DbSet<Scaler> Scalers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketApprovalStatus> TicketApprovalStatuses { get; set; }
        public DbSet<TicketProcessStatus> TicketProcessStatuses { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
        public DbSet<Tract> Tracts { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<WeightUnitType> WeightUnitType { get; set; }


        //using(var context = new ALCContext())
        //{
        //    // var logs = context.Locations.ToList();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<AccountType>().ToTable("AccountTypes");
            modelBuilder.Entity<Authorization>().ToTable("Authorizations");
            modelBuilder.Entity<Buyer>().ToTable("Buyers");
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Commodity>().ToTable("Commodities");
            modelBuilder.Entity<Driver>().ToTable("Drivers");
            modelBuilder.Entity<Location>().ToTable("Locations");
            modelBuilder.Entity<OffloadPoint>().ToTable("OffloadPoints");
            modelBuilder.Entity<Organization>().ToTable("Organizations");
            modelBuilder.Entity<PaymentTerm>().ToTable("PaymentTerms");
            modelBuilder.Entity<Scaler>().ToTable("Scalers");
            modelBuilder.Entity<State>().ToTable("States");
            modelBuilder.Entity<Ticket>().ToTable("Tickets");
            modelBuilder.Entity<TicketApprovalStatus>().ToTable("TicketApprovalStatuses");
            modelBuilder.Entity<TicketProcessStatus>().ToTable("TicketProcessStatuses");
            modelBuilder.Entity<TicketType>().ToTable("TicketTypes");
            modelBuilder.Entity<TicketStatus>().ToTable("TicketStatuses");
            modelBuilder.Entity<Tract>().ToTable("Tracts");
            modelBuilder.Entity<Transportation>().ToTable("Transportations");
            modelBuilder.Entity<WeightUnitType>().ToTable("WeightUnitTypes");


            //modelBuilder.Entity<Account>().ToTable("Accounts");
            //modelBuilder.Entity<AccountType>().ToTable("AccountTypes");
            //modelBuilder.Entity<Authorization>().ToTable("Authorizations");
            //modelBuilder.Entity<Buyer>().ToTable("Buyers");
            //modelBuilder.Entity<Commodity>().ToTable("Commodities");
            //modelBuilder.Entity<Driver>().ToTable("Drivers");
            //modelBuilder.Entity<Location>().ToTable("Locations");
            //modelBuilder.Entity<OffloadPoint>().ToTable("OffloadPoints");
            //modelBuilder.Entity<Organization>().ToTable("Organizations");
            //modelBuilder.Entity<Scaler>().ToTable("Scalers");
            //modelBuilder.Entity<Ticket>().ToTable("Tickets");
            //modelBuilder.Entity<TicketApprovalStatus>().ToTable("TicketApprovalStatuses");
            //modelBuilder.Entity<TicketProcessStatus>().ToTable("TicketProcessStatuses");
            //modelBuilder.Entity<TicketType>().ToTable("TicketTypes");
            //modelBuilder.Entity<TicketStatus>().ToTable("TicketStatuses");
            //modelBuilder.Entity<Tract>().ToTable("Tracts");
            //modelBuilder.Entity<Transportation>().ToTable("Transportations");
            //modelBuilder.Entity<WeightUnitType>().ToTable("WeightUnitTypes");
        }

        //using(var context = new ALCContext())
        //{
        //    // var logs = context.Locations.ToList();
        //} 
    }
}