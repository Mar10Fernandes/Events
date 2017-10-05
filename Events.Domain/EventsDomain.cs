using Events.Domain.Entities;
using Events.Domain.Interfaces;
using Events.Repository.MongoDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Domain
{
    public class EventsDomain : IEventsDomain
    {
        public IList<Event> FindEvents(EventsRepositoryAbst eventsRepository)
        {
            IList<Event> events = eventsRepository.List(x => x.Name == "Test");

            return events;
        }
    }
}
