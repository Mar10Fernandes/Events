using Events.Domain.Entities;
using Events.Domain.Interfaces;
using Events.Repository.MongoDB;
using Events.Repository.MongoDB.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Events.Domain
{
    public class EventsDomain : IEventsDomain
    {
        private EventsRepositoryAbst _eventsRepository;

        public EventsDomain(EventsRepositoryAbst eventsRepository)
        {
            this._eventsRepository = eventsRepository;
        }

        public IEnumerable<Event> FindAll()
        {
            return _eventsRepository.All();
        }
    }
}
