using Microsoft.EntityFrameworkCore;
using PartyAtHomes_Lib;
using System;

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
                    Id = 1,
                    EventName = "Test1",
                    StartDateTime = new DateTime(2019, 11, 04),
                    EndDateTime = new DateTime(2019, 11, 04),
                    AdressCountry = "Belgium",
                    AdressCity = "Tielt",
                    AdressStreet = "Sint Janstraat",
                    AdressNumber = "3",
                    DescriptionEvent = "test event tielt",
                    CreatorId = user.Id,
                    MainImage = "paris.jpg"
                },
                new Event 
                {
                    Id = 2,
                    EventName = "Test2",
                    StartDateTime = new DateTime(2019, 11, 04),
                    EndDateTime = new DateTime(2019, 11, 04),
                    AdressCountry = "Belgium",
                    AdressCity = "Brugge",
                    AdressNumber = "3",
                    AdressStreet = "Rijselstraat",
                    DescriptionEvent = "Test Event Brugge",
                    CreatorId = user.Id,
                    MainImage = "paris.jpg"
                });
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<User> User { get; set; }
    }
}
