using Events.Domain.Entities;
using Events.Repository.MongoDB.Base.Connection;
using Events.Repository.MongoDB.Base;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Events.Repository.MongoDB
{
    public abstract class EventsRepositoryAbst : BaseRepository<Event>, IBaseRepository<Event>
    {
        public EventsRepositoryAbst(IConnect connect) : base(connect)
        {
        }
    }

    public sealed class EventsRepository : EventsRepositoryAbst
    {
        public EventsRepository(IConnect connect) : base(connect)
        {
        }

        public IEnumerable<Event> FindAll()
        {
            return this.All();
        }
    }
}
