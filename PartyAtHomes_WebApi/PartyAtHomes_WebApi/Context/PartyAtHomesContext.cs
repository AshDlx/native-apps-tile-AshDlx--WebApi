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
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasData(
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "chakalaka",
                    LastName = "Boom Boom",
                    UserName = "ChakBoom",
                    Password = "123AZERTY"
                });
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<User> User { get; set; }
    }
}
