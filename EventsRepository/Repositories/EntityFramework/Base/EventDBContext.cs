using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Events.Repository.Repositories.EntityFramework.Base
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }

        //public DbSet<City> Cities { get; set; }
        //public DbSet<Country> Countries { get; set; }
        //public DbSet<Event> Events { get; set; }
        //public DbSet<EventLocation> EventLocations { get; set; }
        //public DbSet<EventRank> EventRanks { get; set; }
        //public DbSet<EventType> EventTypes { get; set; }
    }
}
