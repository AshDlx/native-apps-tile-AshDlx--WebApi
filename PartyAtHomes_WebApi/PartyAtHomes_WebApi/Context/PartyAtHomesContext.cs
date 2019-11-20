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
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "chakalaka",
                LastName = "Boom Boom",
                UserName = "ChakBoom",
                Password = "123AZERTY"
            };
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasData(user);

            modelBuilder.Entity<Event>()
                .ToTable("Events")
                .HasData(
                new Event
                {
                    Id = Guid.NewGuid(),
                    EventName = "Test",
                    StartDateTime = new DateTime(2019, 11, 04),
                    EndDateTime = new DateTime(2019, 11, 04),
                    AdressCountry = "Belgium",
                    AdressCity = "Tielt",
                    AdressNumber = "3",
                    DescriptionEvent = "Test Event",
                    CreatorId = user.Id
                });
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<User> User { get; set; }
    }
}
