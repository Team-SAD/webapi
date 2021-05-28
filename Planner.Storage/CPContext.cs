using System;
using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.Models;

namespace Planner.Storage
{
    public class CPContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        
        

        public CPContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<AppUser>().HasKey(e => e.EntityId);
        builder.Entity<Event>().HasKey(e => e.EntityId);
        builder.Entity<Location>().HasKey(e => e.EntityId);

        OnModelSeeding(builder);
        }

        private static void OnModelSeeding(ModelBuilder builder)
        {
            builder.Entity<AppUser>().HasData(new[]
            {
                new AppUser() { EntityId = 1, Name = "Abdul-Rauf Yakubu" },
                new AppUser() { EntityId = 2, Name = "Daniel Henderson" },
                new AppUser() { EntityId = 3, Name = "Stanhope Nwosu" },
                new AppUser() { EntityId = 4, Name = "Fred Belotte" },
                new AppUser() { EntityId = 5, Name = "Azhya Knox" },
            });

            builder.Entity<Event>().HasData(new[]
            {
                new Event() {EntityId = 1, Description = "First event", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(1.0), Title = "Title 1"},
                new Event() {EntityId = 2, Description = "Second event", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(2.0), Title = "Title 2" },
                new Event() {EntityId = 3, Description = "Third event", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(3.0), Title = "Title 3" }
            });

            builder.Entity<Location>().HasData(new[]
            {
                new Location(){EntityId = 1, City = "City 1", Street = "Street 1", State = "State 1", Zipcode = "45623"},
                new Location(){EntityId = 2, City = "City 2", Street = "Street 2", State = "State 2", Zipcode = "45643"},
                new Location(){EntityId = 3, City = "City ", Street = "Street 3", State = "State 3", Zipcode = "45643"}
            });
        }
        
    }
}