using MongoDB.Driver;
using System;

namespace Events.Repository.MongoDB.Base.Connection
{
    public interface IConnect : IDisposable
    {
        IMongoCollection<T> Collection<T>(string CollectionName);
    }
}
