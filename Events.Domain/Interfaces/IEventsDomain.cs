using Events.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Domain.Interfaces
{
    public interface IEventsDomain
    {
        IEnumerable<Event> FindAll();
    }
}
