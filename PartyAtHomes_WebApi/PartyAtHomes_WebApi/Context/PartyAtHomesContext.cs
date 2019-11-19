using Microsoft.EntityFrameworkCore;
using PartyAtHomes_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyAtHomes_WebApi.Context
{
    public class PartyAtHomesContext : DbContext
    {
        public PartyAtHomesContext(DbContextOptions<PartyAtHomesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Event>()
            //   .ToTable("Events")
            //   .HasData(
            //    new Event
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Party",
            //        City = "Brugge",
            //        Latitude = 50.9964677,
            //        Longitude = 3.3238515,
            //        StartDate = new DateTime(2020, 01, 01),
            //        EndDate = DateTime.Now.Date.AddYears(3)
            //    });
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<User> User { get; set; }
    }
}
