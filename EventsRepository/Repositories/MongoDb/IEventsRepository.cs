using Events.Domain.Entities;
using Events.Repository.MongoDB;
using Events.Repository.MongoDB.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Repository.Repositories
{
    public interface IEventsRepository : IBaseRepository<Event>
    {
    }
}
