using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DataEntities;

namespace Context
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventLocation> EventLocations { get; set; }
        public DbSet<EventRank> EventRanks { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
    }
}
