using System;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.Models;

namespace Planner.Storage
{
    public class CPContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        
        

        public CPContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Customer>().HasKey(e => e.EntityId);
        builder.Entity<Event>().HasKey(e => e.EntityId);
        builder.Entity<Location>().HasKey(e => e.EntityId);

        OnModelSeeding(builder);
        }

        private static void OnModelSeeding(ModelBuilder builder)
        {
        builder.Entity<Customer>().HasData(new[]
        {
            new Customer() { EntityId = 1, Name = "Abdul-Rauf Yakubu" },
            new Customer() { EntityId = 2, Name = "Daniel Henderson" },
            new Customer() { EntityId = 3, Name = "Stanhope Nwosu" },
            new Customer() { EntityId = 4, Name = "Fred Belotte" },
            new Customer() { EntityId = 5, Name = "Azhya Knox" },
        });

        builder.Entity<Event>().HasData(new[]
        {
            new Event() {EntityId = 1, Discription = "First event", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(1.0) },
            new Event() {EntityId = 2, Discription = "Second event", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(2.0) },
            new Event() {EntityId = 3, Discription = "Third event", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(3.0) }
        });
        }
    }
}